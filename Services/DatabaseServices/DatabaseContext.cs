using Microsoft.EntityFrameworkCore;
using SalesPro.Models;
using SalesPro.Models.ModelHelpers;
using System.Configuration;

namespace POS_Generic.Helpers
{
    public class DatabaseContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<TransactionModel> Transactions { get; set; }
        public DbSet<TransactionLogModel> TransactionLogs { get; set; }
        public DbSet<SupplierModel> Suppliers { get; set; }
        public DbSet<PurchaseOrderModel> PurchaseOrders { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<PurchaseOrderItemModel> PurchaseOrderItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            optionsBuilder.UseMySQL(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the keyless entity type in the modelBuilder
            modelBuilder.Entity<ServerDateTimeModel>().HasNoKey();

            modelBuilder.Entity<TransactionModel>().Property(e => e.RowVersion).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();

            base.OnModelCreating(modelBuilder);
        }
    }
}
