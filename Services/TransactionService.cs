using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Helpers;
using SalesPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesPro.Services
{
    public class TransactionService
    {
        public async Task SaveTransaction(TransactionModel transaction, TransactionLogModel log)
        {
            using (var context = new DatabaseContext())
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    // Save the transaction first
                    await context.Transactions.AddAsync(transaction);
                    await context.SaveChangesAsync();

                    // Use the saved transaction's ID in the log
                    log.TransactionId = transaction.TransactionId; // Assuming 'Id' is the primary key

                    await context.TransactionLogs.AddAsync(log);
                    await context.SaveChangesAsync();

                    // Save transaction for global using
                    TransactionSession.SetTransactionId(transaction.TransactionId);
                });
            }
        }


        public async Task UpdateTransaction(int transactionId, decimal begBalance, TransactionLogModel log, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var toUpdate = await context.Transactions.FindAsync(transactionId);
                    NullCheckerHelper.NullCheck(toUpdate);
                    VersionCheckerHelper.ConcurrencyCheck(rowVersion, toUpdate.RowVersion);
                    toUpdate.BeginningBalance = begBalance;
                    await context.TransactionLogs.AddAsync(log);
                    await context.SaveChangesAsync();
                });
            }
        }

        public async Task CloseTransaction(int transactionId, int rowVersion, TransactionModel transaction, TransactionLogModel log)
        {
            using (var context = new DatabaseContext())
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var toUpdate = await context.Transactions.FindAsync(transactionId);
                    NullCheckerHelper.NullCheck(toUpdate);
                    VersionCheckerHelper.ConcurrencyCheck(rowVersion, toUpdate.RowVersion);

                    toUpdate.EndDate = transaction.EndDate;
                    toUpdate.TotalSales = transaction.TotalSales;
                    toUpdate.TotalExpenses = transaction.TotalExpenses;
                    toUpdate.ExpectedCash = transaction.ExpectedCash;
                    toUpdate.EndingCash = transaction.EndingCash;
                    toUpdate.ClosedBy = transaction.ClosedBy;
                    toUpdate.IsClosed = transaction.IsClosed;
                    toUpdate.BalanceStatus = transaction.BalanceStatus;
                    await context.AddAsync(log);
                    await context.SaveChangesAsync();

                });
            }
        }

        public async Task UndoCloseTransaction(int transactionId, int rowVersion, TransactionModel transaction, TransactionLogModel log)
        {
            using (var context = new DatabaseContext())
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var toUpdate = await context.Transactions.FindAsync(transactionId);
                    NullCheckerHelper.NullCheck(toUpdate);
                    VersionCheckerHelper.ConcurrencyCheck(rowVersion, toUpdate.RowVersion);

                    toUpdate.IsClosed = transaction.IsClosed;
                    await context.AddAsync(log);
                    await context.SaveChangesAsync();
                });
            }
        }

        public async Task<List<TransactionLogModel>> GetAllTransactionLogs(int transactionId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.TransactionLogs
                  .Where(x => x.TransactionId == transactionId)
                  .OrderByDescending(x => x.TransactionLogId)
                  .ToListAsync();
            }
        }

        public async Task<TransactionModel> GetTransactionById(int transactionId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.Transactions.FindAsync(transactionId);
            }
        }

        public async Task<bool> HasTransactionsCurrentDay(DateTime currentDate)
        {
            using (var context = new DatabaseContext())
            {
                var result = await context.Transactions
                    .FirstOrDefaultAsync(x => x.StartDate.Date == currentDate.Date && x.IsClosed == false);
                return result != null;
            }
        }

        public async Task<List<TransactionModel>> GetTransactionByDate(DateTime date)
        {
            using (var _dbContext = new DatabaseContext())
            {
                return await _dbContext.Transactions.Where(x => x.StartDate.Date == date.Date).ToListAsync();
            }
        }

        public async Task<List<TransactionModel>> GetUnclosedPastTransactions(DateTime date)
        {
            using (var _dbContext = new DatabaseContext())
            {
                return await _dbContext.Transactions
                    .Where(x => x.StartDate.Date <= date.Date && x.IsClosed == false)
                    .ToListAsync();
            }
        }

        public async Task<List<TransactionModel>> GetAllTransactions()
        {
            using (var _dbContext = new DatabaseContext())
            {
                return await _dbContext.Transactions.OrderByDescending(x => x.TransactionId).ToListAsync();
            }
        }

        public async Task<List<TransactionModel>> GetUnclosedTransactions(DateTime currentDate)
        {
            using (var _dbContext = new DatabaseContext())
            {
                return await _dbContext.Transactions
                    .Where(x => x.IsClosed == false && x.StartDate.Date != currentDate.Date)
                    .OrderByDescending(x => x.TransactionId)
                    .ToListAsync();
            }
        }

        public async Task GetMaxTransactionId()
        {
            using (var context = new DatabaseContext())
            {
                var transactionId = await context.Transactions.AnyAsync()
                 ? await context.Transactions.MaxAsync(x => x.TransactionId)
                 : 0; // Or a suitable default value

                TransactionSession.SetTransactionId(transactionId);
            }
        }
    }
}