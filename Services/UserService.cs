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
    public class UserService
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

        public async Task<UserModel> GetUserIfExist(string fullname)
        {
            using (var context = new DatabaseContext())
            {
                return await context.Users.FirstOrDefaultAsync(x => x.Fullname == fullname);
            }
        }

        public async Task<UserModel> GetUsernameIfExist(string username)
        {
            using (var context = new DatabaseContext())
            {
                return await context.Users.FirstOrDefaultAsync(x => x.Username == username);
            }
        }
    }
}
