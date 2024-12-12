using POS_Generic.Helpers;
using SalesPro.Accessors;
using SalesPro.Accessors.PurchaseOrders;
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
        private readonly PurchaseOrderAccessor _purchaseOrderAccessor;
        public PurchaseOrderService(DatabaseContext context)
        {
            _context = context;
            _supplierBaseAccessor = new Accessor<SupplierModel>();
            _purchaseOrderBaseAccessor = new Accessor<PurchaseOrderModel>();
            _purchaseOrderAccessor = new PurchaseOrderAccessor();
        }

        public async Task<List<SupplierModel>> LoadSuppliers()
        {
            return (await _supplierBaseAccessor.GetAllAsync()).ToList();
        }

        public async Task SavePurchaseOrder(PurchaseOrderModel purchaseOrder)
        {
            await _context.ExecuteInTransactionAsync(async () =>
            {
                await _purchaseOrderBaseAccessor.AddAsync(purchaseOrder);
            });
        }

        public async Task<List<PurchaseOrderModel>> GetAllPurchaseOrders()
        {
            return (await _purchaseOrderBaseAccessor.GetAllAsync()).ToList();
        }

        public async Task<List<PurchaseOrderModelExtended>> GetPurchaseOrdersByProcessStatus(ProcessStatus status)
        {
            var pos = (await _purchaseOrderAccessor.GetPurchaseOrderByProcessStatus(status)).ToList();
            var suppliers = (await _supplierBaseAccessor.GetAllAsync()).ToList();
            return pos with
            {
                SupplierName = suppliers.FirstOrDefault(s => s.SupplierId == pos.SupplierId)?.SupplierName
            };
        }
    }
}
