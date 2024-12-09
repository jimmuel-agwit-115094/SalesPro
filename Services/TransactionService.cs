using POS_Generic.Helpers;
using SalesPro.Accessors;
using SalesPro.Helpers;
using SalesPro.Models;
using System.Collections;
using System.Collections.Generic;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace SalesPro.Services
{
    public class TransactionService
    {
        private readonly DatabaseContext _context;
        private readonly Accessor<TransactionModel> _accessor;
        private readonly Accessor<TransactionLogModel> _baseLogAccessor;
        private readonly TransactionAccessor _transactionAccessor;
        private readonly TransactionLogAccessor _transactionLogAccessor;

        public TransactionService()
        {
            _context = new DatabaseContext();
            _accessor = new Accessor<TransactionModel>(_context);
            _transactionAccessor = new TransactionAccessor();
            _baseLogAccessor = new Accessor<TransactionLogModel>(_context);
            _transactionLogAccessor = new TransactionLogAccessor();
        }

        public async Task SaveTransaction(TransactionModel transaction, TransactionLogModel log)
        {
            await _context.ExecuteInTransactionAsync(async () =>
            {
                var addedTransaction = await _accessor.AddAsync(transaction);
                log.TransactionId = addedTransaction.TransactionId; // Set the transaction ID for logging
                await _baseLogAccessor.AddAsync(log);
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
                await _baseLogAccessor.AddAsync(log);
                MessageHandler.SuccessfullyUpdated();
            });
        }

        public async Task CloseTransaction(int transactionId)
        {
            var updatedTransaction = await _accessor.UpdatePartialAsync<TransactionModel>(
                transactionId,
                t => t.IsClosed = true
            );

            if (updatedTransaction != null)
            {
                MessageHandler.SuccessfullyUpdated();
            }
            MessageHandler.ShowError("Failed to close the transaction. Please try again.");
        }

        public async Task<List<TransactionLogModel>> GetAllTransactionLogs(int transactionId)
        {
            // Directly await the result of the Task
            var transactionLogs = await _transactionLogAccessor.GetTransactionLogsById(transactionId);

            return transactionLogs.ToList().OrderByDescending(x => x.TransactionLogId).ToList();
        }

        public async Task<TransactionModel> GetTransactionById(int transactionId)
        {
            var transaction = await _accessor.GetByIdAsync(transactionId);

            if (transaction == null)
            {
                return null; 
            }
            return transaction;
        }

    }
}
