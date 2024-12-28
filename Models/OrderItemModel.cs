using SalesPro.Enums;
using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class OrderItemModel : BaseEntity
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
    }
}
