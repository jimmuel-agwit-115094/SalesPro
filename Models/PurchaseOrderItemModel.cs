using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class PurchaseOrderItemModel : BaseEntity
    {
        [Key]
        public int PurchaseOrderItemId { get; set; }
        public int PurchaseOrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal SupplierPrice { get; set; }
        public decimal MarkUpPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }

    public class PurchaseOrderItemModelExntended : PurchaseOrderItemModel
    {
        public string ProductName { get; set; }
        public string UnitOfMeasure { get; set; }
    }
}
