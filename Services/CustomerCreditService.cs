using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalesPro.Services
{
    public class CustomerCreditService
    {
        public async Task<CustomerCreditModel> GetCustomerCreditByOrderId(int orderId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.CustomerCredits.FirstOrDefaultAsync(x => x.OrderId == orderId);
            }
        }

        public async Task<List<CustomerCreditModelExtended>> GetCustomerCreditsByStatus(PaymentStatus status)
        {
            using (var context = new DatabaseContext())
            {
                return await (from cr in context.CustomerCredits
                              join c in context.Customers on cr.CustomerId equals c.CustomerId
                              where cr.PaymentStatus == status
                              select new CustomerCreditModelExtended
                              {
                                  CustomerCreditId = cr.CustomerCreditId,
                                  UserName = cr.UserName,
                                  OrderId = cr.OrderId,
                                  CustomerId = cr.CustomerId,
                                  CreditAmount = cr.CreditAmount,
                                  CreditTerms = cr.CreditTerms,
                                  CreditedDate = cr.CreditedDate,
                                  DueDate = cr.DueDate,
                                  PaymentStatus = cr.PaymentStatus,
                                  Notes = cr.Notes,
                                  CustomerName = $"{c.FirstName} {c.MiddleName} {c.LastName}",
                                  ContactNumber = c.ContactNumber
                              }).OrderByDescending(x => x.CreditedDate).ToListAsync();
            }
        }

        public async Task<CustomerCreditModelExtended> GetCustomerCreditById(int customerCreditId)
        {
            using (var context = new DatabaseContext())
            {
                return await (from cr in context.CustomerCredits
                              join c in context.Customers on cr.CustomerId equals c.CustomerId
                              where cr.CustomerCreditId == customerCreditId
                              select new CustomerCreditModelExtended
                              {
                                  CustomerCreditId = cr.CustomerCreditId,
                                  OrderId = cr.OrderId,
                                  UserName = cr.UserName,
                                  CustomerId = cr.CustomerId,
                                  CreditAmount = cr.CreditAmount,
                                  CreditTerms = cr.CreditTerms,
                                  CreditedDate = cr.CreditedDate,
                                  DueDate = cr.DueDate,
                                  PaymentStatus = cr.PaymentStatus,
                                  Notes = cr.Notes,
                                  CustomerName = $"{c.FirstName} {c.MiddleName} {c.LastName}",
                                  ContactNumber = c.ContactNumber
                              }).FirstOrDefaultAsync();
            }
        }

        public async Task<int> GetOrderIdByCustomerCreditId(int customerCreditId)
        {
            using (var context = new DatabaseContext())
            {
                var credit = await context.CustomerCredits.FirstOrDefaultAsync(x => x.CustomerCreditId == customerCreditId);
                return credit.OrderId;
            }
        }
    }
}
