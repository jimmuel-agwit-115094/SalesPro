using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Transactions;

namespace SalesPro.Helpers
{
    public static class DatabaseTransactionHelper
    {
        public static async Task ExecuteInTransactionAsync(this DbContext context, Func<Task> transactionalAction)
        {
            using (var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    await transactionalAction();
                    transactionScope.Complete();
                }
                catch (NullReferenceException nullEx)
                {
                    MessageHandler.ShowError($"No Data to update Error:\n{nullEx.Message}");
                }
                catch (DBConcurrencyException concurrencyEx)
                {
                    MessageHandler.ShowError($"Dirty Data Error:\n{concurrencyEx.Message}");
                }
                catch (InvalidOperationException opEx)
                {
                    MessageHandler.ShowError($"Invalid Operation Error: \n{opEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageHandler.ShowError($"Error occured on executing tranasaction async:\n{ex.Message}");
                }
            }
        }
    }
}
