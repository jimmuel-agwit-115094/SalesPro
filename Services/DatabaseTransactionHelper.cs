using Microsoft.EntityFrameworkCore;
using System;
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
                catch (Exception)
                {
                    MessageHandler.ShowWarning("The information you were trying to update has already been changed or removed by another user. Please refresh the data and try again.");
                }
            }
        }
    }
}
