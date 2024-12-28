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
    }
}
}
