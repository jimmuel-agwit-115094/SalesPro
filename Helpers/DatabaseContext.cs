using Microsoft.EntityFrameworkCore;
using SalesPro.Models;
using System.Configuration;

namespace POS_Generic.Helpers
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            optionsBuilder.UseMySQL(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the keyless entity type in the modelBuilder
            //modelBuilder.Entity<ServerDateTime>().HasNoKey();

            base.OnModelCreating(modelBuilder);
        }
    }
}
