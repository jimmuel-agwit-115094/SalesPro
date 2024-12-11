using POS_Generic.Helpers;
using SalesPro.Accessors;
using SalesPro.Helpers;
using SalesPro.Models;
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

        public TransactionService(DatabaseContext context)
        {
            _context = context;
            _accessor = new Accessor<TransactionModel>();
            _transactionAccessor = new TransactionAccessor();
            _baseTransactionLogAccessor = new Accessor<TransactionLogModel>();
            _transactionLogAccessor = new TransactionLogAccessor();
        }

        public async Task SaveTransaction(TransactionModel transaction, TransactionLogModel log)
        {
            await _context.ExecuteInTransactionAsync(async () =>
            {
                await _accessor.AddAsync(transaction);
                await _baseTransactionLogAccessor.AddAsync(log);
                MessageHandler.SuccessfullyAdded();
            });
        }

        public async Task UpdateTransaction(int transactionId, int rowVersion, decimal begBalance, TransactionLogModel log)
        {
            await _context.ExecuteInTransactionAsync(async () =>
            {
                await _accessor.UpdatePartialAsync<TransactionModel>(
                     transactionId,
                     rowVersion,
                     t =>
                     {
                         t.BeginningBalance = begBalance;
                     }
                );
                await _baseTransactionLogAccessor.AddAsync(log);
                MessageHandler.SuccessfullyUpdated();
            });
        }

        public async Task CloseTransaction(int transactionId, int rowVersion, TransactionModel tr, TransactionLogModel log)
        {
            var date = await ClockHelper.GetServerDateTime();
            await _context.ExecuteInTransactionAsync(async () =>
            {
                await _accessor.UpdatePartialAsync<TransactionModel>(
                        transactionId,
                        rowVersion,
                        t =>
                        {
                            t.TotalSales = tr.TotalSales;
                            t.TotalExpenses = tr.TotalExpenses;
                            t.ExpectedCash = tr.ExpectedCash;
                            t.EndingCash = tr.EndingCash;
                            t.ClosedBy = UserSession.FullName;
                            t.IsClosed = true;
                            t.EndDate = date;
                            t.BalanceStatus = tr.BalanceStatus;
                        }
                  );

                await _baseTransactionLogAccessor.AddAsync(log);
                MessageHandler.SuccessfullyUpdated();
            });
        }

        public async Task UndoCloseTransaction(int transactionId, int rowVersion, TransactionModel tr, TransactionLogModel log)
        {
            var date = await ClockHelper.GetServerDateTime();
            await _context.ExecuteInTransactionAsync(async () =>
            {
                await _accessor.UpdatePartialAsync<TransactionModel>(
                        transactionId,
                        rowVersion,
                        t =>
                        {
                            t.IsClosed = false;
                        }
                  );

                await _baseTransactionLogAccessor.AddAsync(log);
                MessageHandler.SuccessfullyUpdated();
            });
        }

        public async Task<List<TransactionLogModel>> GetAllTransactionLogs(int transactionId)
        {
            var transactionLogs = await _transactionLogAccessor.GetTransactionLogsById(transactionId);
            return transactionLogs.ToList().OrderByDescending(x => x.TransactionLogId).ToList();
        }

        public async Task<TransactionModel> GetTransactionById(int transactionId)
        {
            return await _accessor.GetByIdAsync(transactionId);
        }

    }
}
