using POS_Generic.Helpers;
using SalesPro.Accessors;
using SalesPro.Forms.Transactions;
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
        private readonly DatabaseContext _context;
        private readonly Accessor<TransactionModel> _accessor;
        private readonly Accessor<TransactionLogModel> _baseTransactionLogAccessor;
        private readonly TransactionAccessor _transactionAccessor;
        private readonly TransactionLogAccessor _transactionLogAccessor;

        public TransactionService()
        {
            _context = new DatabaseContext();
            _accessor = new Accessor<TransactionModel>(_context);
            _transactionAccessor = new TransactionAccessor();
            _baseTransactionLogAccessor = new Accessor<TransactionLogModel>(_context);
            _transactionLogAccessor = new TransactionLogAccessor();
        }

        public async Task SaveTransaction(TransactionModel transaction, TransactionLogModel log)
        {
            await _context.ExecuteInTransactionAsync(async () =>
            {
                var addedTransaction = await _accessor.AddAsync(transaction);
                log.TransactionId = addedTransaction.TransactionId; // Set the transaction ID for logging
                await _baseTransactionLogAccessor.AddAsync(log);
                MessageHandler.SuccessfullyAdded();
            });
        }

        public async Task UpdateTransaction(int transactionId, TransactionModel transaction, TransactionLogModel log)
        {
            await _context.ExecuteInTransactionAsync(async () =>
            {
                await _accessor.UpdateAsync(transaction, transactionId);
                log.ActionTaken = Constants.SystemConstants.Updated;
                log.TransactionId = transactionId;
                await _baseTransactionLogAccessor.AddAsync(log);
                MessageHandler.SuccessfullyUpdated();
            });
        }

        public async Task CloseTransaction(int transactionId, TransactionModel tr, TransactionLogModel log)
        {
            var date = await ClockHelper.GetServerDateTime();
            await _context.ExecuteInTransactionAsync(async () =>
            {

                var form = new TransactionDetailsForm();
                await _accessor.UpdatePartialAsync<TransactionModel>(
                      transactionId,
                      t =>
                      {
                          t.TotalSales = tr.TotalSales;
                          t.TotalExpenses = tr.TotalExpenses;
                          t.ExpectedCash = tr.ExpectedCash;
                          t.EndingCash = tr.EndingCash;
                          t.ClosedBy = UserSession.FullName;
                          t.IsClosed = true;
                          t.EndDate = date;
                      }
                );

                await _baseTransactionLogAccessor.AddAsync(log);
                MessageHandler.SuccessfullyUpdated();
            });
           
        }

        public async Task<List<TransactionLogModel>> GetAllTransactionLogs(int transactionId)
        {

            // Directly await the result of the Task
            var transactionLogs = await _transactionLogAccessor.GetTransactionLogsById(transactionId);

            return transactionLogs.ToList().OrderByDescending(x => x.TransactionLogId).ToList();
        }

        public async Task<TransactionModel> GetTransactionById(int transactionId)
        {
            return await _accessor.GetByIdAsync(transactionId);
        }

    }
}
