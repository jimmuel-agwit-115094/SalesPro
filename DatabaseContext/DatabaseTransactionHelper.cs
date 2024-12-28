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
                catch (Exception ex)
                {
                    MessageHandler.ShowError($"Error occured on executing tranasaction async:\n{ex}");
                }
            }
        }
    }
}
