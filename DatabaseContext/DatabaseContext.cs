using Microsoft.EntityFrameworkCore;
using SalesPro.Models;
using SalesPro.Models.ModelHelpers;
using System.Configuration;

namespace POS_Generic.Helpers
{
    public class DatabaseContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<TransactionModel> Transactions { get; set; }
        public DbSet<TransactionLogModel> TransactionLogs { get; set; }
        public DbSet<SupplierModel> Suppliers { get; set; }
        public DbSet<PurchaseOrderModel> PurchaseOrders { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<PurchaseOrderItemModel> PurchaseOrderItems { get; set; }
        public DbSet<PurchaseOrderLogsModel> PurchaseOrderLogs { get; set; }
        public DbSet<InventoryModel> Inventories { get; set; }
        public DbSet<InventoryLogModel> InventoryLogs { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<OrderItemModel> OrderItems { get; set; }
        public DbSet<CustomerCreditModel> CustomerCredits { get; set; }
        public DbSet<ProductLogModel> ProductLogs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            optionsBuilder.UseMySQL(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the keyless entity type in the modelBuilder
            modelBuilder.Entity<ServerDateTimeModel>().HasNoKey();
            base.OnModelCreating(modelBuilder);
        }
    }
}
