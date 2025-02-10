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
        public async Task<List<Orders>> LoadSuppliers()
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

        public async Task<PurchaseOrderModel> SavePurchaseOrder(PurchaseOrderModel purchaseOrder, DateTime date)
        {
            using (var context = new DatabaseContext())
            {
                var savedPo = new PurchaseOrderModel();
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var saved = await context.AddAsync(purchaseOrder);
                    await context.SaveChangesAsync();

                    var logs = new PurchaseOrderLogsModel
                    {
                        PurchaseOrderId = saved.Entity.PurchaseOrderId,
                        UserId = saved.Entity.UserId,
                        PoLogActionStatus = PoLogActionStatus.CreatedPo,
                        Date = date
                    };
                    await context.PurchaseOrderLogs.AddAsync(logs);
                    await context.SaveChangesAsync();
                    savedPo = saved.Entity;
                });
                return savedPo;
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
                                  Remarks = po.Remarks,
                                  UserFullName = u.Fullname,
                                  SupplierName = s.SupplierName
                              }).OrderByDescending(x => x.PurchaseOrderId).ToListAsync();
            }
        }

        public async Task<Orders> GetSupplierById(int supplierId)
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

        public async Task<int> UpdatePurchaseOrder_SupplierId(int purchaseOrderId, int supplierId, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                int result = 0;
                var toUpdate = await context.PurchaseOrders.FindAsync(purchaseOrderId);
                NullCheckerHelper.NullCheck(toUpdate);
                VersionCheckerHelper.ConcurrencyCheck(rowVersion, toUpdate.RowVersion);

                toUpdate.SupplierId = supplierId;
                result = await context.SaveChangesAsync();
                return result > 0 ? result : 0;
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

        public async Task<int> SavePurchaseOrderItem(int purchaseOrderId, PurchaseOrderItemModel poItem, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                int result = 0;
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var toUpdate = await context.PurchaseOrders.FindAsync(purchaseOrderId);
                    NullCheckerHelper.NullCheck(toUpdate);
                    VersionCheckerHelper.ConcurrencyCheck(rowVersion, toUpdate.RowVersion);

                    // save items
                    await context.PurchaseOrderItems.AddAsync(poItem);
                    await context.SaveChangesAsync();

                    // get total price
                    var totalPrice = await context.PurchaseOrderItems
                                .Where(x => x.PurchaseOrderId == purchaseOrderId)
                                .SumAsync(x => x.TotalPrice);
                    toUpdate.PoTotal = totalPrice;
                    result = await context.SaveChangesAsync();

                });
                return result > 0 ? result : 0;
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

        public async Task<PurchaseOrderItemModelExntended> GetPurchaseOrderItemByPoItemId(int poItemId)
        {
            using (var context = new DatabaseContext())
            {
                return await (from pt in context.PurchaseOrderItems
                              join p in context.Products on pt.ProductId equals p.ProductId
                              where pt.PurchaseOrderItemId == poItemId
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
                                  TotalPrice = pt.TotalPrice,
                                  UnitOfMeasure = p.UnitOfMeasure
                              }).FirstOrDefaultAsync();
            }
        }

        public async Task UpdatePurchaseOrder_ProcessStatus(
            int purchaseOrderId,
            int rowVersion,
            int creditTerms,
            ProcessStatus status,
            PurchaseOrderLogsModel purchaseOrderLogs,
            List<InventoryModel> inventories = null,
            List<InventoryLogModel> inventoryLog = null)
        {
            using (var context = new DatabaseContext())
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var toUpdate = await context.PurchaseOrders.FindAsync(purchaseOrderId);
                    NullCheckerHelper.NullCheck(toUpdate);
                    VersionCheckerHelper.ConcurrencyCheck(rowVersion, toUpdate.RowVersion);

                    toUpdate.ProcessStatus = status;
                    toUpdate.CreditTerms = creditTerms;

                    var curDate = await ClockHelper.GetServerDateTime();
                    if (status == ProcessStatus.Completed)
                    {
                        toUpdate.DueDate = curDate.Date.AddDays(creditTerms);
                    }
                    // save po items to inventory
                    if (inventories != null && inventories.Any())
                    {
                        await context.Inventories.AddRangeAsync(inventories);
                    }
                    // save logs
                    await context.PurchaseOrderLogs.AddAsync(purchaseOrderLogs);
                    if (inventoryLog != null && inventoryLog.Any())
                    {
                        await context.InventoryLogs.AddRangeAsync(inventoryLog);
                    }
                    // save all
                    await context.SaveChangesAsync();
                });
            }
        }

        public async Task<int> UpdatePurchaseOrderItems(int poId, int poItemId, PurchaseOrderItemModel poItem, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                int result = 0;
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var poUpdate = await context.PurchaseOrders.FindAsync(poId);
                    var itemUpdate = await context.PurchaseOrderItems.FindAsync(poItemId);
                    NullCheckerHelper.NullCheck(poUpdate);
                    VersionCheckerHelper.ConcurrencyCheck(rowVersion, poUpdate.RowVersion);

                    // update items
                    itemUpdate.Quantity = poItem.Quantity;
                    itemUpdate.SupplierPrice = poItem.SupplierPrice;
                    itemUpdate.MarkUpPrice = poItem.MarkUpPrice;
                    itemUpdate.RetailPrice = poItem.RetailPrice;
                    itemUpdate.TotalPrice = poItem.TotalPrice;
                    itemUpdate.ProductId = poItem.ProductId;
                    await context.SaveChangesAsync();

                    // get total price
                    var totalPrice = await context.PurchaseOrderItems
                                .Where(x => x.PurchaseOrderId == poId)
                                .SumAsync(x => x.TotalPrice);
                    // update total price
                    poUpdate.PoTotal = totalPrice;
                    result = await context.SaveChangesAsync();
                });
                return result > 0 ? result : 0;
            }
        }

        public async Task<int> DeletePurchaseOrderItem(int poId, int poItemId, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                int result = 0;
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var poUpdate = await context.PurchaseOrders.FindAsync(poId);
                    var itemToDelete = await context.PurchaseOrderItems.FindAsync(poItemId);
                    NullCheckerHelper.NullCheck(poUpdate);

                    VersionCheckerHelper.ConcurrencyCheck(rowVersion, poUpdate.RowVersion);

                    // delete item
                    context.PurchaseOrderItems.Remove(itemToDelete);
                    await context.SaveChangesAsync();

                    // get total price
                    var totalPrice = await context.PurchaseOrderItems
                                .Where(x => x.PurchaseOrderId == poId)
                                .SumAsync(x => x.TotalPrice);
                    // update total price
                    poUpdate.PoTotal = totalPrice;
                    result = await context.SaveChangesAsync();

                });
                return result > 0 ? result : 0;
            }
        }

        public async Task<List<PurchaseOrderLogsModelExtended>> GetPurchaseOrderLogsByPoId(int poId)
        {
            using (var context = new DatabaseContext())
            {
                return await (from po in context.PurchaseOrderLogs
                              join u in context.Users on po.UserId equals u.UserId
                              where po.PurchaseOrderId == poId
                              select new PurchaseOrderLogsModelExtended
                              {
                                  PurchaseOrderLogsId = po.PurchaseOrderLogsId,
                                  Date = po.Date,
                                  PurchaseOrderId = po.PurchaseOrderId,
                                  UserFullName = u.Fullname,
                                  PoLogActionStatus = po.PoLogActionStatus

                              }).OrderByDescending(x => x.PurchaseOrderLogsId).ToListAsync();
            }
        }

        public decimal GetLatestSupplierPrice(int productId)
        {
            using (var context = new DatabaseContext())
            {
                return context.Inventories
                    .Where(x => x.ProductId == productId)
                    .OrderByDescending(x => x.DateAdded)
                    .Select(x => x.SupplierPrice)
                    .FirstOrDefault();
            }
        }
    }
}
