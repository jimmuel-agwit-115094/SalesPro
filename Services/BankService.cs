using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Enums;
using SalesPro.Helpers;
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

        // ----------------- CRUD -----------------

        // Save
        public async Task<int> SaveBank(BankModel bank)
        {
            using (var context = new DatabaseContext())
            {
                await context.Banks.AddAsync(bank);
                return await context.SaveChangesAsync();
            }
        }

        public async Task<List<BankModel>> LoadBanks()
        {
            using (var context = new DatabaseContext())
            {
                return await context.Banks.OrderBy(x => x.BankName).ToListAsync();
            }
        }

        public async Task<int> UpdateBank(int bankId, BankModel bank, int bankRowVersion)
        {
            using (var context = new DatabaseContext())
            {
                int success = 0;
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var toUpdate = await context.Banks.FindAsync(bankId);
                    NullCheckerHelper.NullCheck(toUpdate);
                    VersionCheckerHelper.ConcurrencyCheck(toUpdate.RowVersion, bankRowVersion);
                    toUpdate.BankName = bank.BankName;
                    toUpdate.BankType = bank.BankType;
                    toUpdate.Address = bank.Address;
                    toUpdate.Contact = bank.Contact;
                    await context.SaveChangesAsync();
                    success = 1;
                });
                return success;
            }
        }

        public BankModel GetBankById(int bankId)
        {
            using (var context = new DatabaseContext())
            {
                return context.Banks.Find(bankId);
            }
        }
    }
}
