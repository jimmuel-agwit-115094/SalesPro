using POS_Generic.Helpers;
using SalesPro.Helpers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Services
{
    public class GenericService
    {
        public async Task<int> GetRowVersionAsync<T>(int id) where T : class
        {
            using (var context = new DatabaseContext())
            {
                try
                {
                    // Find the entity by its ID
                    var entity = await context.Set<T>().FindAsync(id);

                    if (entity == null)
                    {
                        throw new InvalidOperationException($"Entity of type {typeof(T).Name} with ID {id} not found.");
                    }
                    // Retrieve the RowVersion property directly
                    var rowVersionProperty = context.Entry(entity).Property("RowVersion");
                    return (int)rowVersionProperty.CurrentValue;
                }
                catch (Exception ex)
                {
                    MessageHandler.ShowError($"Error getting row version: {ex.Message}");
                    return 0;
                }
            }
        }

    }
}
