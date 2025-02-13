using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Enums;
using SalesPro.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        public async Task<decimal> GetTotalCashSalesByDate(DateTime start, DateTime end)
        {
            using (var context = new DatabaseContext())
            {
                var totalCashSales = await context.Orders
                    .Where(x => x.DateTaken.Date >= start.Date && x.DateTaken.Date <= end.Date
                    && x.OrderStatus == OrderStatus.Completed
                    && x.PaymentStatus == PaymentStatus.Paid
                    && x.PaymentMethod == PaymentMethod.Cash)
                    .SumAsync(x => x.Total);
                return totalCashSales;
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

        public async Task<List<ReportProductExtended>> GetSellingProducts(DateTime start, DateTime end, bool getTopSelling = true)
        {
            using (var context = new DatabaseContext())
            {
                var query = from oi in context.OrderItems
                            join o in context.Orders on oi.OrderId equals o.OrderId
                            join p in context.Products on oi.ProductId equals p.ProductId
                            where o.OrderStatus == OrderStatus.Completed
                            && o.DatePaid.Value.Date >= start.Date && o.DatePaid.Value.Date <= end.Date
                            && o.PaymentStatus == PaymentStatus.Paid
                            group oi by new
                            {
                                p.ProductId,
                                p.ProductName,
                                p.BarCode,
                                p.UnitOfMeasure,
                                p.Description,
                                p.ReorderLevel
                            }
                            into g
                            select new ReportProductExtended
                            {
                                ProductId = g.Key.ProductId,
                                ProductName = g.Key.ProductName,
                                BarCode = g.Key.BarCode,
                                UnitOfMeasure = g.Key.UnitOfMeasure,
                                Description = g.Key.Description,
                                ReorderLevel = g.Key.ReorderLevel,
                                TotalProductOrdered = g.Sum(x => x.OrderQuantity) // Sum total quantity sold
                            };

                // Apply sorting based on the parameter
                query = getTopSelling ? query.OrderByDescending(p => p.TotalProductOrdered)
                                      : query.OrderBy(p => p.TotalProductOrdered);

                return await query.Take(15).ToListAsync();
            }
        }

        // get high paying customers
        public async Task<List<ReportCustomerExtended>> GetHighPayingCustomers(DateTime start, DateTime end)
        {
            using (var context = new DatabaseContext())
            {
                var query = from o in context.Orders
                            join c in context.Customers on o.CustomerId equals c.CustomerId
                            where o.OrderStatus == OrderStatus.Completed
                            && o.DatePaid.Value.Date >= start.Date && o.DatePaid.Value.Date <= end.Date
                            && o.PaymentStatus == PaymentStatus.Paid
                            && o.CustomerId != 1
                            group o by new
                            {
                                c.CustomerId,
                                c.FirstName,
                                c.LastName,
                                c.MiddleName,
                                c.Email,
                            }
                            into g
                            select new ReportCustomerExtended
                            {
                                FullName = g.Key.FirstName + " " + g.Key.MiddleName + " " + g.Key.LastName,
                                TotalAmountPaid = g.Sum(x => x.Total)
                            };
                return await query.OrderByDescending(c => c.TotalAmountPaid).Take(10).ToListAsync();
            }
        }

        public async Task<List<ReportYearModel>> GetYearlySalesForChart()
        {
            using (var context = new DatabaseContext())
            {
                int currentYear = DateTime.UtcNow.Year;
                int pastYearLimit = currentYear - 6; // Include the current year and the last 6 years

                var query = from o in context.Orders
                            where o.OrderStatus == OrderStatus.Completed
                                  && o.PaymentStatus == PaymentStatus.Paid
                                  && o.DatePaid.HasValue
                                  && o.DatePaid.Value.Year >= pastYearLimit
                            group o by o.DatePaid.Value.Year into g
                            select new ReportYearModel
                            {
                                Year = g.Key,
                                Total = g.Sum(x => x.Total)
                            };

                return await query.OrderBy(x => x.Year).ToListAsync();
            }
        }


        public async Task<List<ReportMonthModel>> GetMonthlySalesForChart()
        {
            using (var context = new DatabaseContext())
            {
                int currentYear = DateTime.UtcNow.Year;

                var query = from o in context.Orders
                            where o.OrderStatus == OrderStatus.Completed
                                  && o.PaymentStatus == PaymentStatus.Paid
                                  && o.DatePaid.HasValue
                                  && o.DatePaid.Value.Year == currentYear
                            group o by o.DatePaid.Value.Month into g
                            select new
                            {
                                MonthNumber = g.Key, // Store month as a number (1-12)
                                Total = g.Sum(x => x.Total)
                            };

                // Fetch data from the database first
                var result = await query.ToListAsync();

                // Convert month numbers to abbreviated names & sort correctly
                var mappedResult = result
                    .OrderBy(x => x.MonthNumber) // ✅ Ensure months are in correct order
                    .Select(x => new ReportMonthModel
                    {
                        Month = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(x.MonthNumber), // Convert to "Jan", "Feb", ...
                        Total = x.Total
                    })
                    .ToList();

                return mappedResult;
            }
        }

    }
}
