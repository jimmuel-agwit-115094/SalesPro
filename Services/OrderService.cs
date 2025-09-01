﻿using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Constants;
using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
                var order = await (from o in context.Orders
                                   join c in context.Customers on o.CustomerId equals c.CustomerId
                                   join u in context.Users on o.UserId equals u.UserId
                                   where o.OrderId == orderId
                                   select new OrderModelExtended
                                   {
                                       OrderId = o.OrderId,
                                       TransactionId = o.TransactionId,
                                       UserId = o.UserId,
                                       CustomerId = o.CustomerId,
                                       DateTaken = o.DateTaken,
                                       Total = o.Total,
                                       DiscountRate = o.DiscountRate,
                                       DiscountAmount = o.DiscountAmount,
                                       Vat = o.Vat,
                                       VatAmount = o.VatAmount,
                                       NetAmount = o.NetAmount,
                                       AmountDue = o.AmountDue,
                                       GrossAmount = o.GrossAmount,
                                       AmountPaid = o.AmountPaid,
                                       Change = o.Change,
                                       PaymentStatus = o.PaymentStatus,
                                       IsCredited = o.IsCredited,
                                       OrderStatus = o.OrderStatus,
                                       PaymentMethod = o.PaymentMethod,
                                       DatePaid = o.DatePaid,

                                       CustomerName = $"{c.FirstName} {c.MiddleName} {c.LastName}",
                                       UserName = u.Fullname,
                                   }).FirstOrDefaultAsync();
                return order;
            }
        }

        public async Task<List<OrderItemModelExtended>> LoadOrderItemsByOrderId(int orderId)
        {
            using (var context = new DatabaseContext())
            {
                return await (from oi in context.OrderItems
                              join p in context.Products on oi.ProductId equals p.ProductId
                              where oi.OrderId == orderId
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
                                  UnitOfMeasure = p.SubUnit == SystemConstants.NotApplicable
                                            ? p.UnitOfMeasure
                                            : p.SubUnit
                              }).ToListAsync();
            }
        }

        public async Task<List<InventoryModelExtended>> SearchProductsFromInventory(string barcode = null, string productName = null)
        {
            using (var context = new DatabaseContext())
            {
                // Start with the base query
                var query = from i in context.Inventories
                            join p in context.Products on i.ProductId equals p.ProductId
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
                                ProductName = p.ProductName,
                                BarCode = p.BarCode,
                                UnitOfMeasure = p.SubUnit == SystemConstants.NotApplicable
                                            ? p.UnitOfMeasure
                                            : p.SubUnit
                            };

                // Apply filtering if optional parameters are provided
                if (!string.IsNullOrWhiteSpace(barcode))
                {
                    query = query.Where(i => i.BarCode == barcode); // Assuming barcode maps to ProductId
                }

                if (!string.IsNullOrWhiteSpace(productName))
                {
                    query = query.Where(i => i.ProductName.Contains(productName)); // Partial match on ProductName
                }

                // Apply sorting and execute the query
                //return await query.OrderBy(p => p.QuantityOnHand == 0)
                //                  .ThenByDescending(p => p.QuantityOnHand)
                //                  .ToListAsync();
                return await query.ToListAsync();
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

        private async Task<bool> UpdateOrder(DatabaseContext context, int orderId, int rowVersion, OrderModel orderModel = null)
        {
            // Fetch the order
            var currentOrder = await context.Orders.FindAsync(orderId);

            NullCheckerHelper.NullCheck(currentOrder);
            bool isConcurrencyValid = VersionCheckerHelper.ConcurrencyCheck(rowVersion, currentOrder.RowVersion);

            if (!isConcurrencyValid)
            {
                return false;
            }

            // Load order items
            var orderedItems = await LoadOrderItemsByOrderId(orderId);

            // Perform calculations
            decimal total = orderedItems.Sum(oi => oi.TotalPrice);
            decimal vatAmt = total * Constants.SystemConstants.VatRate;
            decimal netAmt = total - vatAmt;
            decimal grossAmt = vatAmt + netAmt;

            // Update order with calculated values
            currentOrder.Total = total;
            currentOrder.VatAmount = vatAmt;
            currentOrder.NetAmount = netAmt;
            currentOrder.AmountDue = total;
            currentOrder.GrossAmount = grossAmt;
            currentOrder.UserId = UserSession.Session_UserId;

            // Update when payment is made, not null means theres a value for the ordermodel which 
            // needs to be paid
            if (orderModel != null)
            {
                currentOrder.AmountPaid = orderModel.AmountPaid;
                currentOrder.Change = orderModel.Change;
                currentOrder.DiscountAmount = orderModel.DiscountAmount;
                currentOrder.DiscountRate = orderModel.DiscountRate;
                currentOrder.PaymentMethod = orderModel.PaymentMethod;
                currentOrder.PaymentStatus = PaymentStatus.Paid;
                currentOrder.OrderStatus = OrderStatus.Completed;
                currentOrder.DatePaid = orderModel.DatePaid;
            }
            await context.SaveChangesAsync();
            return true;
        }

        private async Task<List<OrderItemModelExtended>> UpdateInventory(DatabaseContext context, int orderId)
        {
            //var orderedItems = await LoadOrderItemsByOrderId(orderId);
            var orderedItems = await (from oi in context.OrderItems
                                      join p in context.Products on oi.ProductId equals p.ProductId
                                      where oi.OrderId == orderId
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

            var inventoryExceedErrors = new List<OrderItemModelExtended>();

            foreach (var orderItem in orderedItems)
            {
                // Match the inventory ID in the inventory table
                var inventory = await context.Inventories
                    .FirstOrDefaultAsync(i => i.InventoryId == orderItem.InventoryId);
                NullCheckerHelper.NullCheck(inventory);

                // Check if inventory is sufficient
                if (orderItem.OrderItemStatus == OrderItemStatus.Added && orderItem.OrderQuantity > inventory.QuantityOnHand)
                {
                    inventoryExceedErrors.Add(orderItem);
                    continue;  // Skip this order item and continue with the next
                }

                // Convert the new quantity to absolute integer
                int convertedQuantity = Math.Abs(orderItem.OrderQuantity);

                // Update the inventory
                inventory.QuantityOnHand += (orderItem.OrderItemStatus != OrderItemStatus.Added)
                    ? convertedQuantity
                    : -convertedQuantity;

                // Add the inventory logs
                var ds = new InventoryLogModel
                {
                    InventoryId = orderItem.InventoryId,
                    UserId = UserSession.Session_UserId,
                    DateAdjusted = DateTime.Now,
                    InventoryAction = orderItem.OrderItemStatus == OrderItemStatus.Added
                        ? InventoryAction.Negative_Adjustment
                        : InventoryAction.Positive_Adjustment,
                    Remarks = orderItem.OrderItemStatus == OrderItemStatus.Added
                        ? $"Deducted {convertedQuantity}. Added to order."
                        : $"Returned {convertedQuantity} to inventory",
                    CurrentQuantity = inventory.QuantityOnHand,
                    AdjustmentQuantity = convertedQuantity,
                    FinalQuantity = inventory.QuantityOnHand
                };

                // Save log to context
                await context.InventoryLogs.AddAsync(ds);
            }

            if (inventoryExceedErrors.Any())
            {
                return inventoryExceedErrors;
            }

            await context.SaveChangesAsync();
            return inventoryExceedErrors;
        }

        public async Task<OrderModel> UpdateQuantity(int orderItemId, int orderQty, bool isEdit, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                var updatedOrder = new OrderModel();
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var orderItem = await context.OrderItems.FindAsync(orderItemId);
                    NullCheckerHelper.NullCheck(orderItem);

                    // Update orderItem
                    int newQuantity = orderItem.OrderItemStatus == OrderItemStatus.Added ? orderQty : -orderQty;

                    orderItem.OrderQuantity = newQuantity;
                    orderItem.TotalPrice = newQuantity * orderItem.Price;
                    await context.SaveChangesAsync();
                    // Update order
                    await UpdateOrder(context, orderItem.OrderId, rowVersion);

                    updatedOrder = await context.Orders.FindAsync(orderItem.OrderId);
                    await context.Entry(updatedOrder).ReloadAsync();
                });
                return updatedOrder;
            }
        }

        public async Task<OrderResult> SaveOrderItem(int orderId, int inventoryId, OrderItemStatus itemStatus, OrderItemModel orderItem, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                int success = 0;
                var updatedOrder = new OrderModel();
                await context.ExecuteInTransactionAsync(async () =>
                {
                    // Check if the product is already in the order item
                    var inventoryProductExist = await context.OrderItems.Where(x => x.InventoryId == inventoryId && x.OrderId == orderId).FirstOrDefaultAsync();

                    if (inventoryProductExist != null)
                    {
                        // Update the existing order item
                        inventoryProductExist.OrderItemStatus = itemStatus;
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
                    success = 1;
                });

                var result = new OrderResult
                {
                    OrderModel = updatedOrder,
                    SuccessResult = success
                };

                return result;
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

        // Dual return of list and bool to check if the updating of order is success
        public async Task<(List<OrderItemModelExtended>, bool)> PayOrder(int orderId, decimal amountPaid, DateTime curDate, int rowVersion, OrderModel orderModel)
        {
            using (var context = new DatabaseContext())
            {
                bool successUpdate = false;
                var invalidOrders = new List<OrderItemModelExtended>();
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var order = await context.Orders.FindAsync(orderId);
                    NullCheckerHelper.NullCheck(order);

                    // Update order
                    successUpdate = await UpdateOrder(context, orderId, rowVersion, orderModel);

                    // Update inventory
                    invalidOrders = await UpdateInventory(context, order.OrderId);

                    if (invalidOrders.Count > 0)
                    {
                        ThrowIfInsufficientStock(invalidOrders);
                    }
                });
                return (invalidOrders, successUpdate);
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

        public async Task<OrderModel> ChangeOrderStatus(int orderId, OrderStatus status, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                var updatedOrder = new OrderModel();
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var order = await context.Orders.FindAsync(orderId);
                    NullCheckerHelper.NullCheck(order);

                    order.OrderStatus = status;
                    order.UserId = UserSession.Session_UserId;
                    await context.SaveChangesAsync();
                    updatedOrder = await context.Orders.FindAsync(orderId);
                });

                return updatedOrder;
            }
        }

        public async Task<List<OrderModelExtended>> LoadOrders()
        {
            using (var context = new DatabaseContext())
            {
                var query = from o in context.Orders
                            join c in context.Customers on o.CustomerId equals c.CustomerId
                            join u in context.Users on o.UserId equals u.UserId
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
                                IsCredited = o.IsCredited,
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
                            };

                //// Apply filter only if orderStatus is not null
                //if (orderStatus.HasValue)
                //{
                //    query = query.Where(o => o.OrderStatus == orderStatus.Value);
                //}

                return await query.OrderByDescending(x => x.OrderId).ToListAsync();
            }
        }

        public async Task<List<OrderModelExtended>> LoadForResumeOrders(int orderId)
        {
            using (var context = new DatabaseContext())
            {
                var query = from o in context.Orders
                            join c in context.Customers on o.CustomerId equals c.CustomerId
                            join u in context.Users on o.UserId equals u.UserId
                            where o.OrderStatus != OrderStatus.Completed && o.OrderId != orderId
                            orderby o.OrderId descending
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
                                IsCredited = o.IsCredited,
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
                            };

                return await query.ToListAsync();
            }
        }


        public async Task<List<OrderModelExtended>> LoadForViewAllOrders()
        {
            using (var context = new DatabaseContext())
            {
                var query = from o in context.Orders
                            join c in context.Customers on o.CustomerId equals c.CustomerId
                            join u in context.Users on o.UserId equals u.UserId
                            where o.OrderStatus != OrderStatus.Suspended
                            orderby o.OrderId descending
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
                                IsCredited = o.IsCredited,
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
                            };

                return await query.ToListAsync();
            }
        }

        public async Task<OrderModel> UpdateOrderCustomer(int orderId, int customerId, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                var updatedOrder = new OrderModel();
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var order = await context.Orders.FindAsync(orderId);
                    NullCheckerHelper.NullCheck(order);
                    VersionCheckerHelper.ConcurrencyCheck(rowVersion, order.RowVersion);
                    order.CustomerId = customerId;

                    await context.SaveChangesAsync();

                    // Reload the order to get the updated RowVersion
                    updatedOrder = await context.Orders.FindAsync(orderId);
                    //await context.Entry(updatedOrder).ReloadAsync();

                });

                return updatedOrder;
            }
        }

        public static void ThrowIfInsufficientStock(IEnumerable<OrderItemModelExtended> invalidOrders)
        {
            if (invalidOrders == null || !invalidOrders.Any())
                return;

            var productDetails = string.Join("\n", invalidOrders.Select(x => $"- {x.ProductName}"));
            throw new InvalidOperationException($"Sorry, some items in your order are out of stock or have limited availability:\n{productDetails}");

        }

        public async Task<OrderModel> ChargeOrder(int orderId, CustomerCreditModel custCred, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                var updatedOrder = new OrderModel();
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var order = await context.Orders.FindAsync(orderId);
                    NullCheckerHelper.NullCheck(order);
                    VersionCheckerHelper.ConcurrencyCheck(rowVersion, order.RowVersion);

                    // Save Credit
                    await context.CustomerCredits.AddAsync(custCred);
                    await context.SaveChangesAsync();

                    // Update order
                    order.IsCredited = true;
                    order.UserId = UserSession.Session_UserId;
                    order.OrderStatus = OrderStatus.Completed;
                    await context.SaveChangesAsync();

                    // Update inventory
                    var invalidOrders = await UpdateInventory(context, order.OrderId);
                    if (invalidOrders.Count > 0)
                    {
                        ThrowIfInsufficientStock(invalidOrders);
                    }

                    // Reload the order to get the updated RowVersion
                    updatedOrder = await context.Orders.FindAsync(orderId);
                    await context.Entry(updatedOrder).ReloadAsync();
                });

                return updatedOrder;
            }
        }

        public async Task<OrderResult> ProcessOrderItem(OrderItemStatus itemStatus, int inventoryId, int orderId, int quantity, int rowVersion)
        {
            var prodInventory = await GetInventoryById(inventoryId);
            if (prodInventory == null)
            {
                throw new InvalidOperationException("Product not found on inventory. Please select the product and try again.");
            }

            if (itemStatus == OrderItemStatus.Added && quantity > prodInventory.QuantityOnHand)
            {
                throw new InvalidOperationException("Quantity is greater than the available stock.");
            }

            // Check if product is out of stock when already added item
            var existingOrderItem = await GetExistingOrderItem(inventoryId, orderId);
            if (existingOrderItem != null)
            {
                int totalToBeOrdered = existingOrderItem.OrderQuantity + quantity;
                if (itemStatus == OrderItemStatus.Added && totalToBeOrdered > prodInventory.QuantityOnHand)
                {
                    throw new InvalidOperationException($"Stock is limited. You've already added the available quantity to this order.\n" +
                $"Total Ordered: {totalToBeOrdered} \n" +
                $"Available: {prodInventory.QuantityOnHand}");
                }

                // to absolut quantity
                int absQuantity = Math.Abs(existingOrderItem.OrderQuantity);
                if (existingOrderItem.InventoryId == prodInventory.InventoryId
                    && quantity == absQuantity
                    && existingOrderItem.ProductId == prodInventory.ProductId
                    && itemStatus != existingOrderItem.OrderItemStatus)
                {
                    throw new InvalidOperationException("You cannot add and return the same quantity of a product, as it results in a zero quantity. Please adjust the quantity to keep the order valid.");
                }
            }

            // Assess if item is for addition or returned
            int newQuantity = itemStatus == OrderItemStatus.Added ? quantity : -quantity;

            // Save order item
            var orderItem = new OrderItemModel
            {
                OrderId = orderId,
                InventoryId = inventoryId,
                ProductId = prodInventory.ProductId,
                OrderQuantity = newQuantity,
                Price = prodInventory.RetailPrice,
                TotalPrice = newQuantity * prodInventory.RetailPrice,
                OrderItemStatus = itemStatus,
            };

            var order = await SaveOrderItem(orderId, inventoryId, itemStatus, orderItem, rowVersion);

            return order;
        }

        public async Task<int> GetInventoryIdByBarCode(string barcode)
        {
            using (var context = new DatabaseContext())
            {
                var inventory = await (from i in context.Inventories
                                       join p in context.Products on i.ProductId equals p.ProductId
                                       where p.BarCode == barcode
                                       && p.BarCode != null
                                       && p.BarCode != string.Empty
                                       select new InventoryModel
                                       {
                                           InventoryId = i.InventoryId
                                       }).FirstOrDefaultAsync();

                if (inventory != null)
                {
                    return inventory.InventoryId;
                }
                return 0;
            }
        }
    }
}
