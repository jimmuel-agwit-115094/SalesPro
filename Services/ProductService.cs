using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Enums;
using SalesPro.Helpers;
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
                return await context.Products.OrderBy(x => x.ProductName).ToListAsync();
            }
        }

        public async Task<int> SaveProduct(ProductModel product)
        {
            using (var context = new DatabaseContext())
            {
                context.Products.Add(product);
                return await context.SaveChangesAsync();
            }
        }

        public async Task<int> UpdateProduct(int productId, ProductModel productModel, int rowVersion)
        {
            int success = 0;
            using (var context = new DatabaseContext())
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var product = await context.Products.FindAsync(productId);
                    NullCheckerHelper.NullCheck(product);
                    VersionCheckerHelper.ConcurrencyCheck(product.RowVersion, rowVersion);

                    // Save Logs
                    var log = new ProductLogModel
                    {
                        ProductId = product.ProductId,
                        ProductActionType = ProductActionType.Updated,
                        ProductName = product.ProductName,
                        OldValue = product.ProductName,
                        NewValue = productModel.ProductName,
                        PerformedBy = UserSession.FullName,
                        DatePerformed = await ClockHelper.GetServerDateTime(),
                    };
                    await context.ProductLogs.AddAsync(log);
                    await context.SaveChangesAsync();

                    // Update product
                    product.ProductName = productModel.ProductName;
                    product.BarCode = productModel.BarCode;
                    product.UnitOfMeasure = productModel.UnitOfMeasure;
                    product.SubUnit = productModel.SubUnit;
                    product.SubQuantity = product.SubQuantity;
                    product.Description = productModel.Description;
                    product.IsSoldByPrice = productModel.IsSoldByPrice;
                    product.ReorderLevel = productModel.ReorderLevel;
                    await context.SaveChangesAsync();

                    success = 1;
                });
            }
            return success;
        }

        public async Task<ProductModel> GetProductById(int productId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.Products.FindAsync(productId);
            }
        }

        // Get logs of a product
        public async Task<List<ProductLogModel>> GetProductLogs(int productId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.ProductLogs.Where(x => x.ProductId == productId).OrderByDescending(x=>x.ProductLogId).ToListAsync();
            }
        }
    }
}
