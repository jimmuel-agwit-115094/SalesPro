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

        public async Task<int> GetPoRowVersion(int purchaseOrderId)
        {
            using (var context = new DatabaseContext())
            {
                var rowVersion = await context.PurchaseOrders.Where(x => x.PurchaseOrderId == purchaseOrderId).Select(x => x.RowVersion).FirstOrDefaultAsync();
                if (rowVersion != 0)
                {
                    return rowVersion;
                }
                return 0;
            }
        }

        public async Task UpdatePurchaseOrder_SupplierId(int purchaseOrderId, int supplierId)
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

        public async Task<bool> SavePurchaseOrderItem(int purchaseOrderId, PurchaseOrderItemModel poItem, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                bool checker = false;
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var toUpdate = await context.PurchaseOrders.FindAsync(purchaseOrderId);
                    NullCheckerHelper.NullChecker(toUpdate);

                    checker = VersionCheckerHelper.ConcurrencyCheck(rowVersion, toUpdate.RowVersion);
                    if (checker)
                    {
                        // save items
                        await context.PurchaseOrderItems.AddAsync(poItem);
                        await context.SaveChangesAsync();

                        // get total price
                        var totalPrice = await context.PurchaseOrderItems
                                    .Where(x => x.PurchaseOrderId == purchaseOrderId)
                                    .SumAsync(x => x.TotalPrice);
                        toUpdate.PoTotal = totalPrice;
                        await context.SaveChangesAsync();
                    }
                });
                return checker;
            }
        }

        public async Task<List<PurchaseOrderItemModel>> GetPurchaseOrderItemsByPoid(int poId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.PurchaseOrderItems.Where(x => x.PurchaseOrderId == poId).ToListAsync();
            }
        }

        public async Task<decimal> GetTotalPriceByPoId(int poId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.PurchaseOrderItems.Where(x => x.PurchaseOrderId == poId).SumAsync(x => x.TotalPrice);
            }
        }

        public async Task<PurchaseOrderItemModel> GetPurchaseOrderItemByPoItemId(int poItemId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.PurchaseOrderItems.Where(x => x.PurchaseOrderItemId == poItemId).FirstOrDefaultAsync();
            }
        }

        public async Task UpdatePurchaseOrder_ProcessStatus(int purchaseOrderId, int rowVersion, ProcessStatus status, PurchaseOrderLogsModel purchaseOrderLogs)
        {
            using (var context = new DatabaseContext())
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var toUpdate = await context.PurchaseOrders.FindAsync(purchaseOrderId);
                    NullCheckerHelper.NullChecker(toUpdate);
                    toUpdate.ProcessStatus = status;
                    await context.PurchaseOrderLogs.AddAsync(purchaseOrderLogs);
                    await context.SaveChangesAsync();
                });
            }
        }

        public async Task<bool> UpdatePurchaseOrderItems(int poId, int poItemId, PurchaseOrderItemModel poItem, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                bool checker = false;
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var poUpdate = await context.PurchaseOrders.FindAsync(poId);
                    var itemUpdate = await context.PurchaseOrderItems.FindAsync(poItemId);
                    NullCheckerHelper.NullChecker(poUpdate);
                    NullCheckerHelper.NullChecker(itemUpdate);
                    checker = VersionCheckerHelper.ConcurrencyCheck(rowVersion, poUpdate.RowVersion);
                    if (checker)
                    {
                        // update items
                        itemUpdate.Quantity = poItem.Quantity;
                        itemUpdate.SupplierPrice = poItem.SupplierPrice;
                        itemUpdate.MarkUpPrice = poItem.MarkUpPrice;
                        itemUpdate.RetailPrice = poItem.RetailPrice;
                        itemUpdate.TotalPrice = poItem.TotalPrice;
                        await context.SaveChangesAsync();

                        // get total price
                        var totalPrice = await context.PurchaseOrderItems
                                    .Where(x => x.PurchaseOrderId == poId)
                                    .SumAsync(x => x.TotalPrice);
                        // update total price
                        poUpdate.PoTotal = totalPrice;
                        await context.SaveChangesAsync();
                    };
                });
                return checker;
            }
        }
    }
}
