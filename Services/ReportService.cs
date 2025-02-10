using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Enums;
using SalesPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPro.Services
{
    public class ReportService
    {
        private decimal _totalSales;
        private decimal _totalExpenses;
        private decimal _totalCustomerCreditPayment;
        private decimal _totalPaymentToSuppliers;

        public async Task<decimal> GetTotalSalesByDate(DateTime start, DateTime end)
        {
            using (var context = new DatabaseContext())
            {
                var totalSales = await context.Orders
                    .Where(x => x.DateTaken.Date >= start.Date && x.DateTaken.Date <= end.Date
                    && x.OrderStatus == OrderStatus.Completed
                    && x.PaymentStatus == PaymentStatus.Paid)
                    .SumAsync(x => x.Total);
                _totalSales = totalSales;
                return totalSales;
            }
        }

        // get total expenses by date
        public async Task<decimal> GetTotalExpensesByDate(DateTime start, DateTime end)
        {
            using (var context = new DatabaseContext())
            {
                var totalExpenses = await context.Expenses
                    .Where(x => x.DateAdded.Date >= start.Date && x.DateAdded.Date <= end.Date)
                    .SumAsync(x => x.Amount);
                _totalExpenses = totalExpenses;
                return totalExpenses;
            }
        }

        // get customer credit payment
        public async Task<decimal> GetTotalCustomerCreditPaymentByDate(DateTime start, DateTime end)
        {
            using (var context = new DatabaseContext())
            {
                var payments = await (from p in context.Payments
                                      join o in context.Orders on p.ReferenceId equals o.OrderId
                                      where p.PaymentDate.Date >= start.Date && p.PaymentDate.Date <= end.Date
                                      && p.PaymentType == PaymentType.CustomerCredit
                                      select o.Total).SumAsync();
                _totalCustomerCreditPayment = payments;
                return payments;
            }
        }

        // get payment to suppliers
        public async Task<decimal> GetTotalPaymentToSuppliersByDate(DateTime start, DateTime end)
        {
            using (var context = new DatabaseContext())
            {
                var payments = await (from p in context.Payments
                                      join po in context.PurchaseOrders on p.ReferenceId equals po.PurchaseOrderId
                                      where p.PaymentDate.Date >= start.Date && p.PaymentDate.Date <= end.Date
                                         && p.PaymentType == PaymentType.SupplierPayable
                                      select po.PoTotal).SumAsync();
                _totalPaymentToSuppliers = payments;
                return payments;
            }
        }

        // get overa all sales
        public decimal GetOverAllSales()
        {
            using (var context = new DatabaseContext())
            {
                var income = _totalSales + _totalCustomerCreditPayment;
                var deduction = _totalExpenses + _totalPaymentToSuppliers;
                var totalSales = income - deduction;
                return totalSales;

            }
        }

        // get fast selling products
        public async Task<List<ProductModel>> GetFastSellingProduct()
        {
            using (var context = new DatabaseContext())
            {
                var products = await (from o in context.Orders
                                      join oi in context.OrderItems on o.OrderId equals oi.OrderId
                                      join p in context.Products on oi.ProductId equals p.ProductId
                                      where o.OrderStatus == OrderStatus.Completed
                                      && o.PaymentStatus == PaymentStatus.Paid
                                      orderby oi.OrderQuantity descending
                                      
                                      select new ProductModel
                                      {
                                          ProductId = p.ProductId,
                                          ProductName = p.ProductName,
                                          BarCode = p.BarCode,
                                          UnitOfMeasure = p.UnitOfMeasure,
                                          Description = p.Description,
                                          ReorderLevel = p.ReorderLevel
                                      }).Take(6).ToListAsync();
                return products;
            }
        }
    }
}
