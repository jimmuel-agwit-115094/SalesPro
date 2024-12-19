using POS_Generic.Helpers;
using SalesPro.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SalesPro.Enums;

namespace SalesPro.Services
{
    public class InventoryService
    {
        public async Task<List<InventoryModelExtended>> GetAllInventories()
        {
            using (var context = new DatabaseContext())
            {
                return await (from i in context.Inventories
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
                                  InventoryStatus = i.InventoryStatus,
                                  Size = i.Size,
                                  DateAdded = i.DateAdded,
                                  QuantityFromPo = i.QuantityFromPo,
                                  QuantityOnHand = i.QuantityOnHand,
                                  SupplierPrice = i.SupplierPrice,
                                  RetailPrice = i.RetailPrice,
                                  Remarks = i.Remarks,
                                  ProductName = p.ProductName,
                                  SupplierName = s.SupplierName,
                                  UserFullName = u.Fullname
                              }).OrderByDescending(x => x.PurchaseOrderId).ToListAsync();
            }
        }

        public async Task<List<InventoryModelExtended>> GetInventoryByInventoryStatus(InventoryStatus status)
        {
            using (var context = new DatabaseContext())
            {
                return await (from i in context.Inventories
                              join po in context.PurchaseOrders on i.PurchaseOrderId equals po.PurchaseOrderId
                              join p in context.Products on i.ProductId equals p.ProductId
                              join u in context.Users on i.UserId equals u.UserId
                              join s in context.Suppliers on i.SupplierId equals s.SupplierId
                              where i.InventoryStatus == status
                              select new InventoryModelExtended
                              {
                                  InventoryId = i.InventoryId,
                                  PurchaseOrderId = i.PurchaseOrderId,
                                  ProductId = i.ProductId,
                                  SupplierId = i.SupplierId,
                                  UserId = i.UserId,
                                  InventoryStatus = i.InventoryStatus,
                                  Size = i.Size,
                                  DateAdded = i.DateAdded,
                                  QuantityFromPo = i.QuantityFromPo,
                                  QuantityOnHand = i.QuantityOnHand,
                                  SupplierPrice = i.SupplierPrice,
                                  RetailPrice = i.RetailPrice,
                                  Remarks = i.Remarks,
                                  ProductName = p.ProductName,
                                  SupplierName = s.SupplierName,
                                  UserFullName = u.Fullname
                              }).OrderByDescending(x => x.PurchaseOrderId).ToListAsync();
            }
        }
    }
}
