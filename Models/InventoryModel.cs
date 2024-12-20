using SalesPro.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class InventoryModel : BaseEntity
    {
        [Key]
        public int InventoryId { get; set; }
        public int PurchaseOrderId { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int UserId { get; set; }
        public DateTime DateAdded { get; set; }
        public int QuantityFromPo { get; set; }
        public int QuantityOnHand { get; set; }
        public decimal SupplierPrice { get; set; }
        public decimal RetailPrice { get; set; }
    }

    public class InventoryModelExtended : InventoryModel
    {
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
        public string UserFullName { get; set; }
    }

}
