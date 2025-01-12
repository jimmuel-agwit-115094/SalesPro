using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;

namespace SalesPro.Services
{
    public class PaymentsServices
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


        private async Task<int> SavePayment(DatabaseContext context, PaymentType paymentType, PaymentsModel paymentModel, int rowVersion)
        {
            int success = 0;
            if (paymentType == PaymentType.SupplierPayable)
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
            else
            {

            }
            return success;
        }

        private async Task<int> UpdatePayment(DatabaseContext context, PaymentType paymentType, PaymentsModel paymentModel)
        {
            int success = 0;
            if (paymentType == PaymentType.SupplierPayable)
            {
                paymentModel.UserId = paymentModel.UserId;
                paymentModel.PaymentMethod = paymentModel.PaymentMethod;
                paymentModel.ReferenceNumber = paymentModel.ReferenceNumber;
                paymentModel.OrNumber = paymentModel.OrNumber;
                paymentModel.BankId = paymentModel.BankId;
                paymentModel.PaymentDate = paymentModel.PaymentDate;
                paymentModel.Notes = paymentModel.Notes;
                success =await context.SaveChangesAsync();
            }
            else
            {

            }
            return success;
        }

        public async Task<int> PayPurchaseOrder(int poId, PaymentType paymentType, PaymentsModel paymentModel, int rowVersion)
        {
            int success = 0;
            using (var context = new DatabaseContext())
            {
                var existingPo = await context.Payments.FirstOrDefaultAsync(x => x.ReferenceId == poId
                && x.PaymentType == paymentType);

                if (existingPo == null)
                {
                    success =await SavePayment(context, paymentType, paymentModel, rowVersion);
                }
                else
                {
                    success =await UpdatePayment(context, paymentType, existingPo);
                }

                return success;
            }
        }
    }
}
