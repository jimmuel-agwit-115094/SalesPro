using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Helpers;
using SalesPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPro.Services
{
    public class SupplierService
    {
        public async Task<int> SaveSupplier(SupplierModel model)
        {
            using (var context = new DatabaseContext())
            {
                context.Suppliers.Add(model);
                return await context.SaveChangesAsync();
            }
        }

        public async Task<List<SupplierModel>> LoadSuppliers()
        {
            using (var context = new DatabaseContext())
            {
                return await context.Suppliers.Where(x => x.SupplierId != 1).OrderBy(x => x.SupplierName).ToListAsync();
            }
        }

        public async Task<SupplierModel> GetSupplierById(int supplierId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.Suppliers.FindAsync(supplierId);
            }
        }

        public async Task<int> UpdateSupplier(int supplierId, SupplierModel model, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                int success = 0;
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var supToUpdate = await context.Suppliers.FindAsync(supplierId);
                    NullCheckerHelper.NullCheck(supToUpdate);
                    VersionCheckerHelper.ConcurrencyCheck(supToUpdate.RowVersion, rowVersion);

                    supToUpdate.SupplierName = model.SupplierName;
                    supToUpdate.SupplierAddress = model.SupplierAddress;
                    supToUpdate.SupplierContactPerson = model.SupplierContactPerson;
                    supToUpdate.SupplierNumber = model.SupplierNumber;
                    supToUpdate.SupplierTin = model.SupplierTin;
                    await context.SaveChangesAsync();
                    success = 1;
                });
                return success;
            }
        }
    }
}
