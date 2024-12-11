using Microsoft.EntityFrameworkCore.Storage;
using POS_Generic.Helpers;
using SalesPro.Accessors;
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
        public PurchaseOrderService(DatabaseContext context)
        {
            _context = context;
            _supplierBaseAccessor = new Accessor<SupplierModel>();
        }

        public async Task<List<SupplierModel>> LoadSuppliers()
        {
            return (await _supplierBaseAccessor.GetAllAsync()).ToList();
        }
    }
}
