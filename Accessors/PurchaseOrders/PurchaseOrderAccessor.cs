using POS_Generic.Helpers;
using SalesPro.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using SalesPro.Enums;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SalesPro.Accessors.PurchaseOrders
{
    public class PurchaseOrderAccessor
    {
        public async Task<IEnumerable<PurchaseOrderModel>> GetPurchaseOrderByProcessStatus(ProcessStatus processStatus)
        {
            using (var _dbContext = new DatabaseContext())
            {
                return await _dbContext.PurchaseOrders.Where(x => x.ProcessStatus == processStatus).ToListAsync();
            }
        }
    }
}
