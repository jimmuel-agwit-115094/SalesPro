using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesPro.Services
{
    public class ProductService
    {
        public async Task<List<ProductModel>> GetAllProducts()
        {
            using (var context = new DatabaseContext())
            {
                return await context.Products.ToListAsync();
            }
        }

    }
}
