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
    public class PaymentsAndBillingService
    {
        public async Task<List<PurchaseOrderModelExtended>> GetPurchaseOrdersByProcessStatus(PaymentStatus status)
        {
            using (var context = new DatabaseContext())
            {
                return await (from po in context.PurchaseOrders
                              join u in context.Users on po.UserId equals u.UserId
                              join s in context.Suppliers on po.SupplierId equals s.SupplierId
                              where po.PaymentStatus == status
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

        // Pay the purchase order
        public async Task<bool> PayPurchaseOrder(int poId, PaymentType paymentType, PaymentsModel paymentModel)
        {
            using (var context = new DatabaseContext())
            {
                // Find the specific purchase order
                var po = await context.Payments.FirstOrDefaultAsync(x => x.ReferenceId == poId
                && x.PaymentType == paymentType);

                if (paymentType == PaymentType.SupplierPayable)
                {
                    if (po == null)
                    {
                        await context.Payments.AddAsync(paymentModel);
                        await context.SaveChangesAsync();
                    }
                    else
                    {
                        po.UserId = paymentModel.UserId;
                        po.PaymentMethod = paymentModel.PaymentMethod;
                        po.ReferenceNumber = paymentModel.ReferenceNumber;
                        po.OrNumber = paymentModel.OrNumber;
                        po.BankId = paymentModel.BankId;
                        po.PaymentDate = paymentModel.PaymentDate;
                        po.Notes = paymentModel.Notes;
                        await context.SaveChangesAsync();
                    }
                }
                else
                {

                }
              
                return false;
            }
        }
    }
}
