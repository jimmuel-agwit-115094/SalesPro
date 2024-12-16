using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Accessors;
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
                return await context.PurchaseOrders.ToListAsync();
            }
        }

        public async Task<List<PurchaseOrderModel>> GetAllPurchaseOrders()
        {
            return (await _purchaseOrderBaseAccessor.GetAllAsync()).ToList();
        }

        public async Task<List<PurchaseOrderModelExtended>> GetPurchaseOrdersByProcessStatus(ProcessStatus status)
        {
            return await (from po in _context.PurchaseOrders
                          join u in _context.Users on po.UserId equals u.UserId
                          join s in _context.Suppliers on po.SupplierId equals s.SupplierId
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

        public async Task UpdatePurchaseOrder_SupploerId(int purchaseOrderId, int rowVersion, PurchaseOrderItemModel purchaseOrder)
        {
            using (var context = new DatabaseContext())
            {
                var toUpdate = await context.PurchaseOrders.FindAsync(purchaseOrderId);
                if (toUpdate != null)
                {
                    context.Entry(purchaseOrder).CurrentValues.SetValues(toUpdate);
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

        public async Task<int> AddPurchaseOrderItem(int purchaseOrderId, int rowVersion, PurchaseOrderModel purchaseOrder, PurchaseOrderItemModel poItem)
        {
            using (var context = new DatabaseContext())
            {
                var updatedPo = new PurchaseOrderModel();
                //Should not get total from db
                // add random total
                Random random = new Random();
                decimal randomDecimal = (decimal)random.NextDouble();

                await context.ExecuteInTransactionAsync(async () =>
                {
                    var toUpdate = context.PurchaseOrders.FindAsync(purchaseOrderId);
                    context.Entry(purchaseOrder).CurrentValues.SetValues(toUpdate);
                    context.Add(poItem);
                    await context.SaveChangesAsync();
                });
                return updatedPo.RowVersion;
            }

        }

        public async Task UpdatePurchaseOrder_ProcessStatus(int purchaseOrderId, int rowVersion, ProcessStatus status, PurchaseOrderLogsModel purchaseOrderLogs)
        {
            using (var context = new DatabaseContext())
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var toUpdate = await context.PurchaseOrders.FindAsync(purchaseOrderId);

                    if(toUpdate != null)
                    {
                        context.PurchaseOrders.ExecuteUpdate(s => s.SetProperty(e => e.Salary, e => e.Salary + 1000));
                    }
                    await _purchaseOrderBaseAccessor.UpdatePartialAsync<PurchaseOrderModel>(
                         purchaseOrderId,
                         rowVersion,
                         t =>
                         {
                             t.ProcessStatus = status;
                         }
                    );
                    await _purchaseOrderLogsBaseAccessor.AddAsync(purchaseOrderLogs);
                    MessageHandler.SuccessfullyAdded();
                });
            }
           
        }
    }
}
