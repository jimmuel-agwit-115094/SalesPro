﻿using Microsoft.EntityFrameworkCore;
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
                    MessageHandler.ShowError($"Null data error:\n{nullEx}");
                }
                catch (DBConcurrencyException concurrencyEx)
                {
                    MessageHandler.ShowError($"Dirty data error:\n{concurrencyEx}");
                }
                catch (InvalidOperationException opEx)
                {
                    MessageHandler.ShowError($"Invalid operation error: \n{opEx}");
                }
                catch (Exception ex)
                {
                    MessageHandler.ShowError($"Error occured on executing tranasaction async:\n{ex}");
                }
            }
        }
    }
}
