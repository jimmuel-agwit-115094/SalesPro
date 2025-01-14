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
                                  SupplierAddress = s.SupplierAddress
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

        private async Task<int> SavePayment(DatabaseContext context, PaymentType paymentType, PaymentsModel paymentModel, int rowVersion)
        {
            int success = 0;
            if (paymentType == PaymentType.SupplierPayable) // Supplier payables
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    await context.Payments.AddAsync(paymentModel);
                    await context.SaveChangesAsync();

                    var purchaseOrder = await context.PurchaseOrders.FindAsync(paymentModel.ReferenceId);
                    NullCheckerHelper.NullCheck(purchaseOrder);
                    VersionCheckerHelper.ConcurrencyCheck(rowVersion, purchaseOrder.RowVersion);
                    purchaseOrder.PaymentStatus = PaymentStatus.Paid;
                    success = await context.SaveChangesAsync();
                });

            }
            else // Customer credits
            {

            }
            return success;
        }

        public async Task<int> Pay(int poId, PaymentType paymentType, PaymentsModel paymentModel, int rowVersion, int paymentRowVersion)
        {
            int success = 0;
            using (var context = new DatabaseContext())
            {
                success = await SavePayment(context, paymentType, paymentModel, rowVersion);
                return success;
            }
        }

        public async Task UpdatePayment(int referenceId, PaymentType paymentType, PaymentsModel paymentModel, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var payment = await context.Payments.FirstOrDefaultAsync(x => x.ReferenceId == referenceId && x.PaymentType == paymentType);
                    NullCheckerHelper.NullCheck(payment);
                    VersionCheckerHelper.ConcurrencyCheck(rowVersion, payment.RowVersion);
                    payment.PaymentMethod = paymentModel.PaymentMethod;
                    payment.ReferenceNumber = paymentModel.ReferenceNumber;
                    payment.OrNumber = paymentModel.OrNumber;
                    payment.BankName = paymentModel.BankName;
                    payment.Notes = paymentModel.Notes;
                    await context.SaveChangesAsync();
                });
            }
        }

        public async Task UpdateDueDate(int poId, DateTime date)
        {
            using (var context = new DatabaseContext())
            {
                var po = await context.PurchaseOrders.FindAsync(poId);
                NullCheckerHelper.NullCheck(po);
                po.DueDate = date;
                po.CreditTerms = (date - po.DateCreated).Days;
                await context.SaveChangesAsync();
            }
        }
    }
}
