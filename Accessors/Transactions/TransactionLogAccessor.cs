using POS_Generic.Helpers;
using SalesPro.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SalesPro.Accessors
{
    public class TransactionLogAccessor
    {

        public async Task<IEnumerable<TransactionLogModel>> GetTransactionLogsById(int id)
        {
            using (var _dbContext = new DatabaseContext())
            {
                return await _dbContext.TransactionLogs.Where(x => x.TransactionId == id).ToListAsync();
            }
        }
    }
}
