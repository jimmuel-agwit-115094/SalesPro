using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Accessors;
using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesPro.Services
{
    public class PurchaseOrderService
    {
        private readonly DatabaseContext _context;
        private readonly Accessor<SupplierModel> _supplierBaseAccessor;
        private readonly Accessor<PurchaseOrderModel> _purchaseOrderBaseAccessor;
        private readonly Accessor<ProductModel> _productBaseAccessor;
        private readonly Accessor<PurchaseOrderItemModel> _poItemsBaseAccessor;
        private readonly Accessor<PurchaseOrderLogsModel> _purchaseOrderLogsBaseAccessor;
        public PurchaseOrderService(DatabaseContext context)
        {
            _context = context;
            _supplierBaseAccessor = new Accessor<SupplierModel>();
            _purchaseOrderBaseAccessor = new Accessor<PurchaseOrderModel>();
            _productBaseAccessor = new Accessor<ProductModel>();
            _poItemsBaseAccessor = new Accessor<PurchaseOrderItemModel>();
            _purchaseOrderLogsBaseAccessor = new Accessor<PurchaseOrderLogsModel>();
        }

        public async Task<List<SupplierModel>> LoadSuppliers()
        {
            return (await _supplierBaseAccessor.GetAllAsync()).ToList();
        }

        public async Task<List<PurchaseOrderModel>> LoadPurchaseOrders()
        {
            return (await _purchaseOrderBaseAccessor.GetAllAsync()).ToList();
        }

        public async Task<PurchaseOrderModel> SavePurchaseOrder(PurchaseOrderModel purchaseOrder)
        {
            return await _purchaseOrderBaseAccessor.AddAsync(purchaseOrder);
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
            return (await _supplierBaseAccessor.GetByIdAsync(supplierId));
        }

        public async Task UpdatePurchaseOrder_SupploerId(int purchaseOrderId, int rowVersion, int supplierId)
        {
            await _purchaseOrderBaseAccessor.UpdatePartialAsync<PurchaseOrderModel>(
                 purchaseOrderId,
                 rowVersion,
                 t =>
                 {
                     t.SupplierId = supplierId;
                 }
            );
        }

        public async Task<List<ProductModel>> LoadProducts()
        {
            return (await _productBaseAccessor.GetAllAsync()).ToList();
        }

        public async Task<List<PurchaseOrderItemModelExntended>> LoadPurchaseOrderItemsByPoId(int purchaseOrderId)
        {
            return await (from pt in _context.PurchaseOrderItems
                          join p in _context.Products on pt.ProductId equals p.ProductId
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

        public async Task SavePurchaseOrderItem(int purchaseOrderId, int rowVersion, decimal poTotal, PurchaseOrderItemModel poItem)
        {
            await _context.ExecuteInTransactionAsync(async () =>
            {
                await _poItemsBaseAccessor.AddAsync(poItem);
                await _purchaseOrderBaseAccessor.UpdatePartialAsync<PurchaseOrderModel>(
                     purchaseOrderId,
                     rowVersion,
                     t =>
                     {
                         t.PoTotal = poTotal;
                     }
                );
            });
        }

        public async Task UpdatePurchaseOrder_ProcessStatus(int purchaseOrderId, int rowVersion, ProcessStatus status, PurchaseOrderLogsModel purchaseOrderLogs)
        {
            await _context.ExecuteInTransactionAsync(async () =>
            {
                await _purchaseOrderBaseAccessor.UpdatePartialAsync<PurchaseOrderModel>(
                     purchaseOrderId,
                     rowVersion,
                     t =>
                     {
                         t.ProcessStatus = status;
                     }
                );
                await _purchaseOrderLogsBaseAccessor.AddAsync(purchaseOrderLogs);
            });
        }
    }
}
