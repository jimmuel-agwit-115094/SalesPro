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
    public class PaymentsService
    {
        public async Task<List<PurchaseOrderModelExtended>> GetPurchaseOrdersByProcessStatus(PaymentStatus status)
        {
            using (var context = new DatabaseContext())
            {
                return await (from po in context.PurchaseOrders
                              join u in context.Users on po.UserId equals u.UserId
                              join s in context.Suppliers on po.SupplierId equals s.SupplierId
                              where po.PaymentStatus == status && po.ProcessStatus == ProcessStatus.Completed
                              select new PurchaseOrderModelExtended
                              {
                                  PurchaseOrderId = po.PurchaseOrderId,
                                  SupplierId = po.SupplierId,
                                  UserId = po.UserId,
                                  DateCreated = po.DateCreated,
                                  DueDate = po.DueDate,
                                  CreditTerms = po.CreditTerms,
                                  PoTotal = po.PoTotal,
                                  ProcessStatus = po.ProcessStatus,
                                  PaymentStatus = po.PaymentStatus,
                                  Remarks = po.Remarks,
                                  UserFullName = u.Fullname,
                                  SupplierName = s.SupplierName
                              }).OrderByDescending(x => x.PurchaseOrderId).ToListAsync();
            }
        }

        public async Task<PurchaseOrderModelExtended> GetPurchaseOrderById(int poId)
        {
            using (var context = new DatabaseContext())
            {
                return await (from po in context.PurchaseOrders
                              join u in context.Users on po.UserId equals u.UserId
                              join s in context.Suppliers on po.SupplierId equals s.SupplierId
                              where po.PurchaseOrderId == poId
                              select new PurchaseOrderModelExtended
                              {
                                  PurchaseOrderId = po.PurchaseOrderId,
                                  SupplierId = po.SupplierId,
                                  UserId = po.UserId,
                                  DateCreated = po.DateCreated,
                                  DueDate = po.DueDate,
                                  CreditTerms = po.CreditTerms,
                                  PoTotal = po.PoTotal,
                                  ProcessStatus = po.ProcessStatus,
                                  PaymentStatus = po.PaymentStatus,
                                  Remarks = po.Remarks,
                                  UserFullName = u.Fullname,
                                  SupplierName = s.SupplierName,
                                  SupplierContactNumber = s.SupplierNumber,
                                  SupplierAddress = s.SupplierAddress,
                                  RowVersion = po.RowVersion
                              }).FirstOrDefaultAsync();
            }
        }

        // get payment by reference id
        public async Task<PaymentsModel> GetPaymentByReferenceId(int referenceId, PaymentType paymentType)
        {
            using (var context = new DatabaseContext())
            {
                return await context.Payments.FirstOrDefaultAsync(x => x.ReferenceId == referenceId && x.PaymentType == paymentType);
            }
        }

        private async Task<PaymentLogModel> BuildPaymentLogModelAsync(PaymentsModel payment)
        {
            var curDate = await ClockHelper.GetServerDateTime();

            return new PaymentLogModel
            {
                PaymentId = payment.PaymentId,
                PaymentMethod = payment.PaymentMethod,
                DatePerformed = curDate,
                ReferenceNo = payment.ReferenceNumber,
                OrNumber = payment.OrNumber,
                Bank = payment.BankName,
                Notes = payment.Notes
            };
        }


        private async Task<int> SavePayment(DatabaseContext context, PaymentType paymentType, PaymentsModel paymentModel, OrderModel orderModel, int rowVersion)
        {
            int success = 0;
            if (paymentType == PaymentType.SupplierPayable) // Supplier payables
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    await context.Payments.AddAsync(paymentModel);
                    await context.SaveChangesAsync();

                    // Save payment logs
                    var paymentLog = await BuildPaymentLogModelAsync(paymentModel);
                    await context.PaymentLogs.AddAsync(paymentLog);

                    var purchaseOrder = await context.PurchaseOrders.FindAsync(paymentModel.ReferenceId);
                    NullCheckerHelper.NullCheck(purchaseOrder);
                    VersionCheckerHelper.ConcurrencyCheck(rowVersion, purchaseOrder.RowVersion);
                    purchaseOrder.PaymentStatus = PaymentStatus.Paid;
                    success = await context.SaveChangesAsync();
                });
            }
            else // Customer credits
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    await context.Payments.AddAsync(paymentModel);
                    await context.SaveChangesAsync();

                    // Save payment logs
                    var paymentLog = await BuildPaymentLogModelAsync(paymentModel);
                    await context.PaymentLogs.AddAsync(paymentLog);

                    // Update orders
                    var order = await context.Orders.FindAsync(orderModel.OrderId);
                    NullCheckerHelper.NullCheck(order);
                    order.AmountPaid = orderModel.AmountPaid;
                    order.PaymentStatus = PaymentStatus.Paid;
                    order.DatePaid = orderModel.DatePaid;
                    order.PaymentMethod = orderModel.PaymentMethod;
                    await context.SaveChangesAsync();

                    // Update customer credits
                    var customerCredit = await context.CustomerCredits.FindAsync(paymentModel.ReferenceId);
                    NullCheckerHelper.NullCheck(customerCredit);
                    VersionCheckerHelper.ConcurrencyCheck(rowVersion, customerCredit.RowVersion);
                    customerCredit.PaymentStatus = PaymentStatus.Paid;
                    success = await context.SaveChangesAsync();
                });
            }
            return success;
        }

        public async Task<int> Pay(int poId, PaymentsModel paymentModel, OrderModel order, int rowVersion, int paymentRowVersion)
        {
            int success = 0;
            using (var context = new DatabaseContext())
            {
                success = await SavePayment(context, paymentModel.PaymentType, paymentModel, order, rowVersion);
                return success;
            }
        }

        public async Task<int> UpdatePayment(int referenceId, PaymentType paymentType, PaymentsModel paymentModel, int rowVersion)
        {
            int success = 0;
            using (var context = new DatabaseContext())
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var payment = await context.Payments.FirstOrDefaultAsync(x => x.ReferenceId == referenceId && x.PaymentType == paymentType);
                    NullCheckerHelper.NullCheck(payment);
                    VersionCheckerHelper.ConcurrencyCheck(rowVersion, payment.RowVersion);

                    // Save payment details
                    payment.PaymentMethod = paymentModel.PaymentMethod;
                    payment.ReferenceNumber = paymentModel.ReferenceNumber;
                    payment.OrNumber = paymentModel.OrNumber;
                    payment.BankName = paymentModel.BankName;
                    payment.Notes = paymentModel.Notes;

                    // Save payment logs
                    var paymentLog = await BuildPaymentLogModelAsync(payment);
                    await context.PaymentLogs.AddAsync(paymentLog);

                    await context.SaveChangesAsync();
                    success = 1;
                });
            }
            return success;
        }

        public async Task<int> UpdateSupplierPayableDueDate(int poId, DateTime date, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                int success = 0;
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var po = await context.PurchaseOrders.FindAsync(poId);
                    NullCheckerHelper.NullCheck(po);
                    VersionCheckerHelper.ConcurrencyCheck(rowVersion, po.RowVersion);
                    po.DueDate = date;
                    po.CreditTerms = (date - po.DateCreated).Days;
                    success = await context.SaveChangesAsync();
                });
                return success;
            }
        }

        public async Task<int> UpdateCustomerCreditDueDate(int customerCreditId, DateTime date, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                int success = 0;
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var creds = await context.CustomerCredits.FindAsync(customerCreditId);
                    NullCheckerHelper.NullCheck(creds);
                    VersionCheckerHelper.ConcurrencyCheck(rowVersion, creds.RowVersion);
                    creds.DueDate = date;
                    creds.CreditTerms = (date - creds.CreditedDate).Days;
                    success = await context.SaveChangesAsync();
                });
                return success;
            }
        }

        public async Task<List<CustomerCreditModelExtended>> GetCustomerCrtedits(PaymentStatus status)
        {
            using (var context = new DatabaseContext())
            {
                return await (from c in context.CustomerCredits
                              join cus in context.CustomerCredits on c.CustomerId equals cus.CustomerId
                              where c.PaymentStatus == status
                              select new CustomerCreditModelExtended
                              {
                                  OrderId = c.OrderId,
                                  CustomerId = c.CustomerId,
                                  CreditAmount = c.CreditAmount,
                                  CreditTerms = c.CreditTerms,
                                  CreditedDate = c.CreditedDate,
                                  DueDate = c.DueDate,
                                  InvoiceNumber = c.InvoiceNumber,
                                  PaymentStatus = c.PaymentStatus,
                                  Notes = c.Notes
                              }).OrderByDescending(x => x.CustomerCreditId).ToListAsync();
            }
        }
    }
}
