using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPro.Services
{
    public class CustomerService
    {
        public async Task<List<CustomerModel>> GetCustomers()
        {
            using (var context = new DatabaseContext())
            {
                return await context.Customers.Where(x => x.CustomerId != 1).ToListAsync();
            }
        }
    }
}
