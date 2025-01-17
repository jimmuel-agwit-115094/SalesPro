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

        public async Task SaveCustomer(CustomerModel model)
        {
            using (var context = new DatabaseContext())
            {
                context.Customers.Add(model);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateCustomer(int customerId, CustomerModel model)
        {
            using (var context = new DatabaseContext())
            {
                var customerToUpdate = await context.Customers.FindAsync(customerId);
                customerToUpdate.FirstName = model.FirstName;
                customerToUpdate.MiddleName = model.MiddleName;
                customerToUpdate.LastName = model.LastName;
                customerToUpdate.Address = model.Address;
                customerToUpdate.Email = model.Email;
                customerToUpdate.ContactNumber = model.ContactNumber;
                await context.SaveChangesAsync();
            }
        }

        public async Task<CustomerModel> GetCustomerById(int customerId)
        {
            using (var context = new DatabaseContext())
            {
                return await context.Customers.FindAsync(customerId);
            }
        }

        public async Task<CustomerModel> IsCustomerExist(string firstName, string lastName, string middleName)
        {
            using (var context = new DatabaseContext())
            {
                return await context.Customers.FirstOrDefaultAsync(x => x.FirstName == firstName && x.LastName == lastName && x.MiddleName == middleName);
            }
        }
    }
}
