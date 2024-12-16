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
    public class PurchaseOrderService
    {
        public async Task<List<SupplierModel>> LoadSuppliers()
        {
            using (var context = new DatabaseContext())
            {
                return await context.Suppliers.ToListAsync();
            }
        }

        public async Task<List<PurchaseOrderModel>> LoadPurchaseOrders()
        {
            using (var context = new DatabaseContext())
            {
                return await context.PurchaseOrders.ToListAsync();
            }
        }

        public async Task<PurchaseOrderModel> SavePurchaseOrder(PurchaseOrderModel purchaseOrder)
        {
            using (var context = new DatabaseContext())
            {
                var saved = await context.AddAsync(purchaseOrder);
                await context.SaveChangesAsync();
                return saved.Entity;
            }
        }

        public async Task<List<PurchaseOrderModel>> GetAllPurchaseOrders()
        {
            using (var context = new DatabaseContext())
            {
                return await context.PurchaseOrders.ToListAsync();
            }
        }

        public async Task<List<PurchaseOrderModelExtended>> GetPurchaseOrdersByProcessStatus(ProcessStatus status)
        {
            using (var context = new DatabaseContext())
            {
                return await (from po in context.PurchaseOrders
                              join u in context.Users on po.UserId equals u.UserId
                              join s in context.Suppliers on po.SupplierId equals s.SupplierId
                              where po.ProcessStatus == status
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
                                  CancellationReason = po.CancellationReason,
                                  Remarks = po.Remarks,
                                  UserFullName = u.Fullname,
                                  SupplierName = s.SupplierName
                              }).OrderByDescending(x => x.PurchaseOrderId).ToListAsync();
            }
        }

        public async Task<SupplierModel> GetSupplierById(int supplierId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.Suppliers.FindAsync(supplierId);
            }
        }

        public async Task<PurchaseOrderModel> GetPurchaseorderById(int purchaseOrderId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.PurchaseOrders.FindAsync(purchaseOrderId);
            }
        }

        public async Task UpdatePurchaseOrder_SupploerId(int purchaseOrderId, int supplierId)
        {
            using (var context = new DatabaseContext())
            {
                var toUpdate = await context.PurchaseOrders.FindAsync(purchaseOrderId);
                if (toUpdate != null)
                {
                    toUpdate.SupplierId = supplierId;
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task<List<ProductModel>> LoadProducts()
        {
            using (var context = new DatabaseContext())
            {
                return await context.Products.ToListAsync();
            }
        }

        public async Task<List<PurchaseOrderItemModelExntended>> LoadPurchaseOrderItemsByPoId(int purchaseOrderId)
        {
            using (var context = new DatabaseContext())
            {
                return await (from pt in context.PurchaseOrderItems
                              join p in context.Products on pt.ProductId equals p.ProductId
                              where pt.PurchaseOrderId == purchaseOrderId
                              select new PurchaseOrderItemModelExntended
                              {
                                  PurchaseOrderItemId = pt.PurchaseOrderItemId,
                                  PurchaseOrderId = pt.PurchaseOrderId,
                                  ProductId = pt.ProductId,
                                  ProductName = p.ProductName,
                                  Quantity = pt.Quantity,
                                  SupplierPrice = pt.SupplierPrice,
                                  MarkUpPrice = pt.MarkUpPrice,
                                  RetailPrice = pt.RetailPrice,
                                  TotalPrice = pt.TotalPrice
                              }).OrderByDescending(x => x.PurchaseOrderItemId).ToListAsync();
            }
        }

        public async Task SavePurchaseOrderItem(int purchaseOrderId, decimal poTotal, PurchaseOrderItemModel poItem)
        {
            using (var context = new DatabaseContext())
            {
                //Should not get total from db
                // add random total
                Random random = new Random();
                decimal randomDecimal = (decimal)random.NextDouble();

                await context.ExecuteInTransactionAsync(async () =>
                {
                    var toUpdate = context.PurchaseOrders.FindAsync(purchaseOrderId);
                    if (toUpdate != null)
                    {
                        toUpdate.Result.PoTotal = poTotal;
                    }
                    //context.Entry(purchaseOrder).CurrentValues.SetValues(toUpdate);
                    await context.AddAsync(poItem);
                    await context.SaveChangesAsync();
                });
            }

        }

        public async Task UpdatePurchaseOrder_ProcessStatus(int purchaseOrderId, int rowVersion, ProcessStatus status, PurchaseOrderLogsModel purchaseOrderLogs)
        {
            using (var context = new DatabaseContext())
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var toUpdate = await context.PurchaseOrders.FindAsync(purchaseOrderId);

                    if (toUpdate != null)
                    {
                        toUpdate.ProcessStatus = status;
                        await context.PurchaseOrderLogs.AddAsync(purchaseOrderLogs);
                        await context.SaveChangesAsync();
                    }
                });
            }

        }
    }
}
