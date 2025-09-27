﻿using Microsoft.EntityFrameworkCore;
using SalesPro.Helpers;
using SalesPro.Models;
using SalesPro.Models.ModelHelpers;
using System;
using System.Configuration;

[assembly: System.Reflection.AssemblyMetadata("DisableILDasm", "true")]

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
        public DbSet<UnitOfMeasuresModel> UnitOfMeasures { get; set; }
        public DbSet<PaymentsModel> Payments { get; set; }
        public DbSet<BankModel> Banks { get; set; }
        public DbSet<ExpenseModel> Expenses { get; set; }
        public DbSet<ActivationModel> Activation { get; set; }
        public DbSet<UserAccessModel> UserAccess { get; set; }
        public DbSet<RoleModel> Roles { get; set; }
        public DbSet<PaymentLogModel> PaymentLogs { get; set; }

        // Note : The password for the database connection string is encrypted and will use the License Generator 
        // app to decrypt the password.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string encryptedConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            string decryptedPassword = DatabaseSecurityService.GetDecryptedPassword();
            string finalConnectionString = encryptedConnectionString.Replace(DatabaseSecurityService.ExtractPassword(encryptedConnectionString), decryptedPassword);

            optionsBuilder.UseMySQL(finalConnectionString);

            Array.Clear(decryptedPassword.ToCharArray(), 0, decryptedPassword.Length);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the keyless entity type in the modelBuilder
            modelBuilder.Entity<ServerDateTimeModel>().HasNoKey();
            base.OnModelCreating(modelBuilder);
        }
    }
}
