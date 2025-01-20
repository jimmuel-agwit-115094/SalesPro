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
    public class ExpenseService
    {

        public async Task<int> SaveExpense(ExpenseModel expense)
        {
            using (var context = new DatabaseContext())
            {
                await context.Expenses.AddAsync(expense);
                return await context.SaveChangesAsync();
            }
        }

        public async Task<List<ExpenseModel>> LoadAllExpenses()
        {
            using (var context = new DatabaseContext())
            {
                return await context.Expenses.ToListAsync();
            }
        }

        public async Task<List<ExpenseModel>> LoadAllExpensesByDate(DateTime date)
        {
            using (var context = new DatabaseContext())
            {
                return await context.Expenses.Where(x => x.DateAdded.Date == date.Date).ToListAsync();
            }
        }

        public async Task<ExpenseModel> GetExpenseById(int expenseId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.Expenses.FindAsync(expenseId);
            }
        }

        public async Task<int> UpdateExpense(int expenseId, ExpenseModel model, int rowVersion)
        {
            int success = 0;
            using (var context = new DatabaseContext())
            {
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var expense = await context.Expenses.FindAsync(expenseId);
                    NullCheckerHelper.NullCheck(expense);
                    VersionCheckerHelper.ConcurrencyCheck(rowVersion, expense.RowVersion);
                    expense.DateAdded = model.DateAdded;
                    expense.ExpenseParticular = model.ExpenseParticular;
                    expense.Amount = model.Amount;
                    expense.Company = model.Company;
                    expense.ReceiptNumber = model.ReceiptNumber;
                    success = await context.SaveChangesAsync();
                });
            }
            return success;
        }
    }
}
