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
                                  TotalPrice = oi.TotalPrice
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

        public async Task<OrderModel> SaveItemAndUpdateOrder(int orderId, OrderItemStatus itemStatus, OrderItemModel orderItem)
        {
            using (var context = new DatabaseContext())
            {
                var updatedOrder = new OrderModel();
                await context.ExecuteInTransactionAsync(async () =>
                {
                    // Add the order item
                    await context.OrderItems.AddAsync(orderItem);
                    await context.SaveChangesAsync();

                    // Fetch the order and compute totals
                    var order = await context.Orders.FindAsync(orderId);
                    if (order != null)
                    {
                        var orderedItems = await LoadOrderItemsByOrderId(orderId);
                        // Calculations
                        decimal total = orderedItems.Sum(oi => oi.TotalPrice);
                        decimal vatAmount = total / Constants.SystemConstants.VatRate;
                        decimal netAmount = total - vatAmount;
                        decimal grossAmount = vatAmount + netAmount;

                        // Update order
                        order.Total = total;
                        order.VatAmount = vatAmount;
                        order.NetAmount = netAmount;
                        order.AmountDue = total;
                        order.GrossAmount = grossAmount;
                        await context.SaveChangesAsync();
                    }

                    // Update inventory
                    var inventory = await context.Inventories.FindAsync(orderItem.InventoryId);
                    if (inventory != null)
                    {
                        inventory.QuantityOnHand += (itemStatus != OrderItemStatus.Added)
                        ? orderItem.OrderQuantity
                        : -orderItem.OrderQuantity;

                        await context.SaveChangesAsync();
                    }
                    updatedOrder = await context.Orders.FindAsync(orderId);
                });
                return updatedOrder;
            }
        }

    }
}
