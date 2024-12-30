using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Models;
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

        private static OrderModel CalculateOrderTotals(decimal total)
        {
            var vatAmt = total / Constants.SystemConstants.VatRate;
            var netAmt = total - vatAmt;
            var grossAmt = vatAmt + netAmt;

            return new OrderModel
            {
                Total = total,
                VatAmount = vatAmt,
                NetAmount = netAmt,
                GrossAmount = grossAmt
            };
        }

        private async Task UpdateOrder(DatabaseContext context, int orderId, int rowVersion)
        {
            // Fetch the order
            var order = await context.Orders.FindAsync(orderId);
            NullCheckerHelper.NullCheck(order);
            VersionCheckerHelper.ConcurrencyCheck(rowVersion, order.RowVersion);

            // Load order items
            var orderedItems = await LoadOrderItemsByOrderId(orderId);

            // Perform calculations
            var calculations = CalculateOrderTotals(total: orderedItems.Sum(oi => oi.TotalPrice));

            // Update order with calculated values
            order.Total = calculations.Total;
            order.VatAmount = calculations.VatAmount;
            order.NetAmount = calculations.NetAmount;
            order.AmountDue = calculations.AmountDue;
            order.GrossAmount = calculations.GrossAmount;

            // Save changes to the database
            await context.SaveChangesAsync();
        }

        private async Task UpdateInventory(DatabaseContext context, int inventoryId, int orderQuantity, OrderItemStatus itemStatus)
        {
            // Fetch the inventory
            var inventory = await context.Inventories.FindAsync(inventoryId);
            NullCheckerHelper.NullCheck(inventory);

            // Update inventory quantity
            inventory.QuantityOnHand += (itemStatus != OrderItemStatus.Added)
                ? orderQuantity
                : -orderQuantity;

            // Save changes to the database
            await context.SaveChangesAsync();
        }

        public async Task UpdateQuantity(int orderItemId, int newQuantity, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var orderItem = await context.OrderItems.FindAsync(orderItemId);
                    NullCheckerHelper.NullCheck(orderItem);

                    // Update order
                    await UpdateOrder(context, orderItem.OrderId, rowVersion);
                    // Update inventory
                    await UpdateInventory(context, orderItem.InventoryId, newQuantity, orderItem.OrderItemStatus);
                });
            }
        }

        public async Task<OrderModel> SaveItemAndUpdateOrder(int orderId, int inventoryId, OrderItemStatus itemStatus, OrderItemModel orderItem, int rowVersion)
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
                    await UpdateOrder(context, orderId, rowVersion);

                    // Update inventory
                    await UpdateInventory(context, orderItem.InventoryId, orderItem.OrderQuantity, itemStatus);

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
    }
}
