using POS_Generic.Helpers;
using System.Threading.Tasks;
using System;
using SalesPro.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SalesPro.Helpers;

namespace SalesPro.Accessors
{
    public class TransactionAccessor
    {
        public async Task<IEnumerable<TransactionModel>> GetTransactionByDate(DateTime datte)
        {
            using (var _dbContext = new DatabaseContext())
            {
                return await _dbContext.Transactions.Where(x => x.StartDate.Date == datte.Date).ToListAsync();
            }
        }

        public async Task<TransactionModel> UpdateTransaction(int transactionId)
        {
            using (var _dbContext = new DatabaseContext())
            {
                var toUpdate = await _dbContext.Transactions.FindAsync(transactionId);
                if (toUpdate == null)
                {
                    MessageHandler.ShowError($"Transaction not found for id: {transactionId}");
                    return null;
                }

                toUpdate.IsClosed = true;
                await _dbContext.SaveChangesAsync();
                return toUpdate;
            }
        }
    }
}
