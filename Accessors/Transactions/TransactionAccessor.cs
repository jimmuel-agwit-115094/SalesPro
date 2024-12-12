using POS_Generic.Helpers;
using System.Threading.Tasks;
using System;
using SalesPro.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

    }
}
