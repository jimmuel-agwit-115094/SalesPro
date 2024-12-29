using SalesPro.Enums;
using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class OrderItemModel
    {
        [Key]
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public int OrderQuantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public OrderItemStatus OrderItemStatus { get; set; }
        public bool IsDeleted { get; set; } 
    }

    public class OrderItemModelExtended : OrderItemModel
    {
        public string ProductName { get; set; }
        public string UnitOfMeasure { get; set; }
    }
}