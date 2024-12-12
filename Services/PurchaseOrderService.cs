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
        public PurchaseOrderService(DatabaseContext context)
        {
            _context = context;
            _supplierBaseAccessor = new Accessor<SupplierModel>();
            _purchaseOrderBaseAccessor = new Accessor<PurchaseOrderModel>();
        }

        public async Task<List<SupplierModel>> LoadSuppliers()
        {
            return (await _supplierBaseAccessor.GetAllAsync()).ToList();
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

        public async Task UpdatePurchaseOrder(int purchaseOrderId, int rowVersion, int supplierId)
        {
            await _context.ExecuteInTransactionAsync(async () =>
            {
                await _purchaseOrderBaseAccessor.UpdatePartialAsync<PurchaseOrderModel>(
                     purchaseOrderId,
                     rowVersion,
                     t =>
                     {
                         t.SupplierId = supplierId;
                     }
                );
            });
        }
    }
}
