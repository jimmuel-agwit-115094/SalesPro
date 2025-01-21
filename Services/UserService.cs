using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Helpers;
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

        public async Task<int> SaveUser(UserModel user)
        {
            using (var context = new DatabaseContext())
            {
                context.Users.Add(user);
                return await context.SaveChangesAsync();
            }
        }

        public async Task<int> UpdateUser(int userId, UserModel user, int rowVersion)
        {
            using (var context = new DatabaseContext())
            {
                int success = 0;
                await context.ExecuteInTransactionAsync(async () =>
                {
                    var userToUpdate = await context.Users.FindAsync(userId);
                    NullCheckerHelper.NullCheck(userToUpdate);
                    VersionCheckerHelper.ConcurrencyCheck(userToUpdate.RowVersion, rowVersion);

                    userToUpdate.Fullname = user.Fullname;
                    userToUpdate.Username = user.Username;
                    userToUpdate.Password = user.Password;
                    userToUpdate.Pin = user.Pin;
                    userToUpdate.UserAccess = user.UserAccess;
                    userToUpdate.UserId = userId;
                    await context.SaveChangesAsync();
                    success = 1;
                });
                return success;
            }
        }

        public async Task<UserModel> GetUserIfExist(string fullname, int id)
        {
            using (var context = new DatabaseContext())
            {
                return await context.Users.FirstOrDefaultAsync(x => x.Fullname == fullname && x.UserId != id);
            }
        }

        public async Task<UserModel> GetUsernameIfExist(string username, int id)
        {
            using (var context = new DatabaseContext())
            {
                return await context.Users.FirstOrDefaultAsync(x => x.Username == username && x.UserId != id);
            }
        }

        public async Task<UserModel> GetUserById(int userId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.Users.FindAsync(userId);
            }
        }
    }
}
