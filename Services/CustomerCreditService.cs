using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Models;
using System.Threading.Tasks;

namespace SalesPro.Services
{
    public class CustomerCreditService
    {
        public async Task<CustomerCreditModel> GetCustomerCreditByOrderId(int orderId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.CustomerCredits.FirstOrDefaultAsync(x => x.OrderId == orderId);
            }
        }
    }
}
