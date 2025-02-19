namespace SalesPro.Constants
{
    public class RoleConstants
    {
        // Modules
        public const string TransactionsModule = "transactions";
        public const string OrdersModule = "orders";
        public const string PurchaseOrdersModule = "purchase-orders";
        public const string ProductsModule = "products";
        public const string InventoryModule = "inventory";
        public const string PaymentsAndBillingsModule = "payments-and-billings";
        public const string ReportsModule = "reports";
        public const string SettingsModule = "settings";

        // Actions
        public const string UpsertProduct = "upsert-product";
        public const string AdjustInventoryQuantity = "adjust-inventory-quantity";
        public const string UpdateSupplierCreditDueDate = "update-supplier-credit-due-date";
        public const string UpdateCustomerCreditDueDate = "update-customer-credit-due-date";
        public const string PaySupplier = "pay-supplier";
        public const string ReceiveCustomerCredit = "receive-customer-credit";

        public const string UpsertUser = "upsert-user";
        public const string UpsertBank = "upsert-bank";
        public const string UpsertSupplier = "upsert-supplier";

        public const string BackupDatabase = "backup-database";
        public const string RestoreDatabase = "restore-database";
        public const string UpdateUserRole = "update-user-role";

        public const string ManageRoles = "manage-roles";
    }
}
