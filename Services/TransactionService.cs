using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;

namespace SalesPro.Helpers
{
    public static class TransactionService
    {
        public static async Task ExecuteInTransactionAsync(this DbContext context, Func<Task> transactionalAction)
        {
            var transaction = await context.Database.BeginTransactionAsync(); // Start the transaction
            try
            {
                await transactionalAction(); // Execute the transactional action

                await transaction.CommitAsync(); // Commit the transaction
            }
            catch
            {
                await transaction.RollbackAsync(); // Rollback in case of an error
                MessageHandler.ShowError("The information you were trying to update has already been changed or removed by another user. Please refresh the data and try again.");
            }
            finally
            {
                await transaction.DisposeAsync(); // Dispose the transaction
            }
        }

    }
}
