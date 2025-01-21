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
    public class SettingService
    {
        public async Task<List<UserModel>> LoadUsers()
        {
            using (var context = new DatabaseContext())
            {
                return await context.Users.ToListAsync();
            }
        }

        public async Task SaveUser(UserModel user)
        {
            using (var context = new DatabaseContext())
            {
                context.Users.Add(user);
                await context.SaveChangesAsync();
            }
        }

    }
}
