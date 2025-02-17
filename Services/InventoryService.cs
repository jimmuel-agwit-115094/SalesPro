using POS_Generic.Helpers;
using SalesPro.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SalesPro.Enums;
using SalesPro.Helpers;

namespace SalesPro.Services
{
    public class InventoryService
    {
        public async Task<List<InventoryModelExtended>> GetFilteredInventories()
        {
            using (var context = new DatabaseContext())
            {
                var query = from i in context.Inventories
                            join po in context.PurchaseOrders on i.PurchaseOrderId equals po.PurchaseOrderId
                            join p in context.Products on i.ProductId equals p.ProductId
                            join u in context.Users on i.UserId equals u.UserId
                            join s in context.Suppliers on i.SupplierId equals s.SupplierId
                            select new InventoryModelExtended
                            {
                                InventoryId = i.InventoryId,
                                PurchaseOrderId = i.PurchaseOrderId,
                                ProductId = i.ProductId,
                                SupplierId = i.SupplierId,
                                UserId = i.UserId,
                                DateAdded = i.DateAdded,
                                QuantityFromPo = i.QuantityFromPo,
                                QuantityOnHand = i.QuantityOnHand,
                                SupplierPrice = i.SupplierPrice,
                                RetailPrice = i.RetailPrice,
                                ProductName = p.ProductName,
                                SupplierName = s.SupplierName,
                                UserFullName = u.Fullname,
                                ReorderLevel = p.ReorderLevel
                            };

                return await query.OrderByDescending(x => x.PurchaseOrderId).ToListAsync();
            }
        }

        public async Task<List<InventoryProductExtended>> GetLowStockProducts()
        {
            using (var context = new DatabaseContext())
            {
                var query = context.Inventories
                    .Join(context.Products,
                          i => i.ProductId,
                          p => p.ProductId,
                          (i, p) => new { p.ProductName, p.ReorderLevel, i.QuantityOnHand })
                    .GroupBy(x => new { x.ProductName, x.ReorderLevel })
                    .Where(g => g.Sum(x => x.QuantityOnHand) < g.Key.ReorderLevel || g.Sum(x => x.QuantityOnHand) < 0)
                    .Select(g => new InventoryProductExtended
                    {
                        ProductName = g.Key.ProductName,
                        Stock = g.Sum(x => x.QuantityOnHand)
                    })
                    .OrderByDescending(x => x.ProductName);

                return await query.ToListAsync();
            }
        }


        public async Task<InventoryModelExtended> GetExtendedInventoryById(int inventoryId)
        {
            using (var context = new DatabaseContext())
            {
                return await (from i in context.Inventories
                              join po in context.PurchaseOrders on i.PurchaseOrderId equals po.PurchaseOrderId
                              join p in context.Products on i.ProductId equals p.ProductId
                              join u in context.Users on i.UserId equals u.UserId
                              join s in context.Suppliers on i.SupplierId equals s.SupplierId
                              where i.InventoryId == inventoryId
                              select new InventoryModelExtended
                              {
                                  InventoryId = i.InventoryId,
                                  PurchaseOrderId = i.PurchaseOrderId,
                                  ProductId = i.ProductId,
                                  SupplierId = i.SupplierId,
                                  UserId = i.UserId,
                                  DateAdded = i.DateAdded,
                                  QuantityFromPo = i.QuantityFromPo,
                                  QuantityOnHand = i.QuantityOnHand,
                                  SupplierPrice = i.SupplierPrice,
                                  RetailPrice = i.RetailPrice,
                                  ProductName = p.ProductName,
                                  SupplierName = s.SupplierName,
                                  UserFullName = u.Fullname,
                                  UnitOfMeasure = p.UnitOfMeasure

                              }).FirstOrDefaultAsync();
            }
        }


        // Get inventory by id
        public async Task<InventoryModel> GetInventoryById(int inventoryId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.Inventories.FindAsync(inventoryId);
            }
        }

        public async Task<int> UpdateInventory(int inventoryId, int adjustingQty, InventoryAction action, InventoryLogModel invLog)
        {
            using (var context = new DatabaseContext())
            {
                int result = 0;
                var toUpdate = await context.Inventories.FindAsync(inventoryId);
                NullCheckerHelper.NullCheck(toUpdate);
                await context.ExecuteInTransactionAsync(async () =>
                {
                    int updateQty = action == InventoryAction.Positive_Adjustment
                        ? toUpdate.QuantityOnHand + adjustingQty
                        : toUpdate.QuantityOnHand - adjustingQty;

                    toUpdate.QuantityOnHand = updateQty;
                    await context.InventoryLogs.AddAsync(invLog);
                    result = await context.SaveChangesAsync();
                });
                return result > 0 ? result : 0;
            }
        }

        public async Task<List<InventoryLogModelExtended>> GetInventoryLogsById(int inventoryId)
        {

            using (var context = new DatabaseContext())
            {
                return await (from i in context.InventoryLogs
                              join s in context.Users on i.UserId equals s.UserId
                              where i.InventoryId == inventoryId
                              select new InventoryLogModelExtended
                              {
                                  InventoryLogId = i.InventoryLogId,
                                  InventoryId = i.InventoryId,
                                  UserId = i.UserId,
                                  DateAdded = i.DateAdded,
                                  DateAdjusted = i.DateAdjusted,
                                  InventoryAction = i.InventoryAction,
                                  CurrentQuantity = i.CurrentQuantity,
                                  AdjustmentQuantity = i.AdjustmentQuantity,
                                  FinalQuantity = i.FinalQuantity,
                                  UserFullName = s.Fullname,
                                  Remarks = i.Remarks
                              }).OrderByDescending(x => x.InventoryLogId).ToListAsync();
            }
        }

    }
}
