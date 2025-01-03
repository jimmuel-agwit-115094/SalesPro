using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesPro.Services
{
    public class OrderService
    {

        public async Task<OrderModel> SaveOrder(OrderModel order)
        {
            using (var context = new DatabaseContext())
            {
                context.Orders.Add(order);
                await context.SaveChangesAsync();
                return order;
            }
        }

        public async Task<int> GetRowVersion(int orderId)
        {
            using (var context = new DatabaseContext())
            {
                var order = await context.Orders.FindAsync(orderId);
                return order.RowVersion;
            }
        }

        public async Task<OrderModelExtended> GetOrderById(int orderId)
        {
            using (var context = new DatabaseContext())
            {
                return await (from o in context.Orders
                              join oi in context.OrderItems on o.OrderId equals oi.OrderId
                              join c in context.Customers on o.CustomerId equals c.CustomerId
                              join u in context.Users on o.UserId equals u.UserId
                              where o.OrderId == orderId
                              select new OrderModelExtended
                              {
                                  AmountDue = o.AmountDue,
                                  AmountPaid = o.AmountPaid,
                                  Change = o.Change,
                                  CustomerId = o.CustomerId,
                                  DatePaid = o.DatePaid,
                                  DateTaken = o.DateTaken,
                                  DiscountAmount = o.DiscountAmount,
                                  DiscountRate = o.DiscountRate,
                                  NetAmount = o.NetAmount,
                                  OrderId = o.OrderId,
                                  OrderStatus = o.OrderStatus,
                                  PaymentMethod = o.PaymentMethod,
                                  PaymentStatus = o.PaymentStatus,
                                  Total = o.Total,
                                  UserId = o.UserId,
                                  Vat = o.Vat,
                                  VatAmount = o.VatAmount,
                                  CustomerName = $"{c.FirstName} {c.MiddleName} {c.LastName}",
                                  UserName = u.Fullname,

                              }).FirstOrDefaultAsync();
            }
        }

        public async Task<List<OrderItemModelExtended>> LoadOrderItemsByOrderId(int orderId)
        {
            using (var context = new DatabaseContext())
            {
                return await (from oi in context.OrderItems
                              join p in context.Products on oi.ProductId equals p.ProductId
                              where oi.OrderId == orderId && oi.OrderItemStatus == OrderItemStatus.Added
                              select new OrderItemModelExtended
                              {
                                  OrderId = orderId,
                                  InventoryId = oi.InventoryId,
                                  OrderItemId = oi.OrderItemId,
                                  OrderItemStatus = oi.OrderItemStatus,
                                  OrderQuantity = oi.OrderQuantity,
                                  Price = oi.Price,
                                  ProductId = oi.ProductId,
                                  ProductName = p.ProductName,
                                  TotalPrice = oi.TotalPrice,
                                  UnitOfMeasure = p.UnitOfMeasure
                              }).ToListAsync();
            }
        }

        public async Task<List<InventoryModelExtended>> LoadProductsFromInventory()
        {
            using (var context = new DatabaseContext())
            {
                return await (from i in context.Inventories
                              join p in context.Products on i.ProductId equals p.ProductId
                              where i.QuantityOnHand > 0
                              select new InventoryModelExtended
                              {
                                  DateAdded = i.DateAdded,
                                  InventoryId = i.InventoryId,
                                  ProductId = i.ProductId,
                                  PurchaseOrderId = i.PurchaseOrderId,
                                  QuantityFromPo = i.QuantityFromPo,
                                  QuantityOnHand = i.QuantityOnHand,
                                  RetailPrice = i.RetailPrice,
                                  SupplierId = i.SupplierId,
                                  SupplierPrice = i.SupplierPrice,
                                  UserId = i.UserId,
                                  ProductName = p.ProductName
                              }).ToListAsync();

            }
        }

        public async Task<InventoryModel> GetInventoryById(int inventoryId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.Inventories.FindAsync(inventoryId);
            }
        }

        public async Task<OrderItemModel> GetExistingOrderItem(int inventoryId, int orderId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.OrderItems
                    .Where(oi => oi.InventoryId == inventoryId && oi.OrderId == orderId)
                    .FirstOrDefaultAsync();
            }
        }

        private static OrderModel CalculateOrderTotals(decimal total, decimal amtPaid = 0)
        {
            var vatAmt = total / Constants.SystemConstants.VatRate;
            var netAmt = total - vatAmt;
            var grossAmt = vatAmt + netAmt;

            return new OrderModel
            {
                Total = total,
                VatAmount = vatAmt,
                NetAmount = netAmt,
                GrossAmount = grossAmt,
                AmountPaid = amtPaid,
                Change = amtPaid - total,
            };
        }

        private async Task UpdateOrder(DatabaseContext context, int orderId, int rowVersion, OrderModel orderModel = null)
        {
            // Fetch the order
            var currentOrder = await context.Orders.FindAsync(orderId);
            NullCheckerHelper.NullCheck(currentOrder);
            VersionCheckerHelper.ConcurrencyCheck(rowVersion, currentOrder.RowVersion);

            // Load order items
            var orderedItems = await LoadOrderItemsByOrderId(orderId);

            // Perform calculations
            var total = orderedItems.Sum(oi => oi.TotalPrice);
            var vatAmt = total / Constants.SystemConstants.VatRate;
            var netAmt = total - vatAmt;
            var grossAmt = vatAmt + netAmt;

            // Update order with calculated values
            currentOrder.Total = total;
            currentOrder.VatAmount = vatAmt;
            currentOrder.NetAmount = netAmt;
            currentOrder.AmountDue = total;
            currentOrder.GrossAmount = grossAmt;

            if (orderModel != null)
            {
                currentOrder.AmountPaid = orderModel.AmountPaid;
                currentOrder.Change = orderModel.Change;
                currentOrder.DiscountAmount = orderModel.DiscountAmount;
                currentOrder.DiscountRate = orderModel.DiscountRate;
                currentOrder.PaymentMethod = orderModel.PaymentMethod;
                currentOrder.PaymentStatus = PaymentStatus.Paid;
                currentOrder.DatePaid = orderModel.DatePaid;
            }

            // Save changes to the database
            await context.SaveChangesAsync();
        }

        private async Task<List<OrderItemModelExtended>> UpdateInventory(DatabaseContext context, int orderId)
        {
            var orderedItems = await LoadOrderItemsByOrderId(orderId);
            var inventoryExceedErrors = new List<OrderItemModelExtended>();

            foreach (var orderItem in orderedItems)
            {
                // Match the inventory ID in the inventory table
                var inventory = await context.Inventories
                    .FirstOrDefaultAsync(i => i.InventoryId == orderItem.InventoryId);
                NullCheckerHelper.NullCheck(inventory);

                // Check if inventory is sufficient
                if (orderItem.OrderItemStatus != OrderItemStatus.Added || orderItem.OrderQuantity > inventory.QuantityOnHand)
                {
                    inventoryExceedErrors.Add(orderItem);
                    continue;  // Skip this order item and continue with the next
                }

                // Update the inventory
                inventory.QuantityOnHand += (orderItem.OrderItemStatus != OrderItemStatus.Added)
                    ? orderItem.OrderQuantity
                    : -orderItem.OrderQuantity;
            }

            if (inventoryExceedErrors.Any())
            {
                return inventoryExceedErrors;
            }

            await context.SaveChangesAsync();
            return inventoryExceedErrors;
        }



        public async Task UpdateQuantity(int orderItemId, int orderQty, bool isEdit, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var orderItem = await context.OrderItems.FindAsync(orderItemId);
                    var existingOrderQty = orderItem.OrderQuantity;
                    NullCheckerHelper.NullCheck(orderItem);
                    // Update orderItem
                    orderItem.OrderQuantity = orderQty;
                    orderItem.TotalPrice = orderQty * orderItem.Price;
                    await context.SaveChangesAsync();
                    // Update order
                    await UpdateOrder(context, orderItem.OrderId, rowVersion);
                    // Update inventory
                    // Note : We added the optional parameter existingOrderQty
                    // await UpdateInventory(context, orderItem.InventoryId, orderQty, isEdit, orderItem.OrderItemStatus, existingOrderQty);
                });
            }
        }

        public async Task<OrderModel> SaveOrderItem(int orderId, int inventoryId, OrderItemStatus itemStatus, OrderItemModel orderItem, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                var updatedOrder = new OrderModel();
                await context.ExecuteInTransactionAsync(async () =>
                {
                    // Check if the product is already in the order item
                    var inventoryProductExist = await context.OrderItems.Where(x => x.InventoryId == inventoryId && x.OrderId == orderId).FirstOrDefaultAsync();

                    if (inventoryProductExist != null)
                    {
                        // Update the existing order item
                        inventoryProductExist.OrderQuantity += orderItem.OrderQuantity;
                        inventoryProductExist.TotalPrice = inventoryProductExist.OrderQuantity * inventoryProductExist.Price;
                        await context.SaveChangesAsync();
                    }
                    else
                    {
                        // Add the order items
                        await context.OrderItems.AddAsync(orderItem);
                        await context.SaveChangesAsync();
                    }

                    // Fetch and update order
                    await UpdateOrder(context, orderItem.OrderId, rowVersion);

                    // Reload the order to get the updated RowVersion
                    updatedOrder = await context.Orders.FindAsync(orderId);
                    await context.Entry(updatedOrder).ReloadAsync();

                });

                return updatedOrder;
            }
        }

        public async Task<CustomerModel> GetCustomerById(int customerId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.Customers.FindAsync(customerId);
            }
        }

        public async Task<OrderItemModelExtended> GetOrderItemById(int orderItemId)
        {
            using (var context = new DatabaseContext())
            {
                return await (from oi in context.OrderItems
                              join p in context.Products on oi.ProductId equals p.ProductId
                              where oi.OrderItemId == orderItemId
                              select new OrderItemModelExtended
                              {
                                  OrderId = orderItemId,
                                  InventoryId = oi.InventoryId,
                                  OrderItemId = oi.OrderItemId,
                                  OrderItemStatus = oi.OrderItemStatus,
                                  OrderQuantity = oi.OrderQuantity,
                                  Price = oi.Price,
                                  ProductId = oi.ProductId,
                                  ProductName = p.ProductName,
                                  TotalPrice = oi.TotalPrice,
                                  UnitOfMeasure = p.UnitOfMeasure
                              }).FirstOrDefaultAsync();
            }
        }

        public async Task<List<OrderItemModelExtended>> PayOrder(int orderId, decimal amountPaid, DateTime curDate, int rowVersion, OrderModel orderModel)
        {
            using (var context = new DatabaseContext())
            {
                var invalidOrders = new List<OrderItemModelExtended>();
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var order = await context.Orders.FindAsync(orderId);
                    NullCheckerHelper.NullCheck(order);

                    // Update order
                    await UpdateOrder(context, orderId, rowVersion, orderModel);

                    // Update inventory
                    invalidOrders = await UpdateInventory(context, order.OrderId);

                    if (invalidOrders.Count > 0)
                    {
                        var productDetails = string.Join("\n", invalidOrders.Select(x => $"- {x.ProductName}"));
                        throw new InvalidOperationException($"The following inventory items have insufficient stock:\n{productDetails}");
                    }
                });
                return invalidOrders;
            }
        }

        public async Task<OrderModel> GetLatestOrder()
        {
            using (var context = new DatabaseContext())
            {
                var latestOrder = await context.Orders
                                 .OrderByDescending(o => o.OrderId)
                                 .FirstOrDefaultAsync();
                return latestOrder;
            }
        }

        public async Task DeleteOrderItem(int orderItemId, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var orderItem = await context.OrderItems.FindAsync(orderItemId);
                    NullCheckerHelper.NullCheck(orderItem);
                    context.OrderItems.Remove(orderItem);
                    await context.SaveChangesAsync();

                    await UpdateOrder(context, orderItem.OrderId, rowVersion);
                });
            }
        }

        // suspend order
        public async Task SuspendOrder(int orderId, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var order = await context.Orders.FindAsync(orderId);
                    NullCheckerHelper.NullCheck(order);
                    order.OrderStatus = OrderStatus.Suspended;
                    await context.SaveChangesAsync();
                });
            }
        }

        public async Task<List<OrderModelExtended>> LoadOrdersByStatus(OrderStatus orderStatus)
        {
            using (var context = new DatabaseContext())
            {
                return await (from o in context.Orders
                              join c in context.Customers on o.CustomerId equals c.CustomerId
                              join u in context.Users on o.UserId equals u.UserId
                              where o.OrderStatus == orderStatus
                              select new OrderModelExtended
                              {
                                  AmountDue = o.AmountDue,
                                  AmountPaid = o.AmountPaid,
                                  Change = o.Change,
                                  CustomerId = o.CustomerId,
                                  DatePaid = o.DatePaid,
                                  DateTaken = o.DateTaken,
                                  DiscountAmount = o.DiscountAmount,
                                  DiscountRate = o.DiscountRate,
                                  NetAmount = o.NetAmount,
                                  OrderId = o.OrderId,
                                  OrderStatus = o.OrderStatus,
                                  PaymentMethod = o.PaymentMethod,
                                  PaymentStatus = o.PaymentStatus,
                                  Total = o.Total,
                                  UserId = o.UserId,
                                  Vat = o.Vat,
                                  VatAmount = o.VatAmount,
                                  CustomerName = $"{c.FirstName} {c.MiddleName} {c.LastName}",
                                  UserName = u.Fullname,
                              }).OrderByDescending(x => x.OrderId).ToListAsync();
            }
        }
    }
}
