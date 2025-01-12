using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Enums;
using SalesPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPro.Services
{
    public class BankService
    {
        public async Task<List<BankModel>> GetBanks()
        {
            using (var context = new DatabaseContext())
            {
               return await context.Banks.Where(x => x.BankId != 1).ToListAsync();
            }
        }
    }
}
