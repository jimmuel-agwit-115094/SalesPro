using SalesPro.Enums;
using System;
namespace SalesPro.Models
{
    public class InventoryLogModel : BaseEntity
    {
        public int InventoryLogId { get; set; }
        public int InventoryId { get; set; }
        public int UserId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateAdjusted { get; set; }
        public InventoryAction InventoryAction { get; set; }
        public string Reason { get; set; }
        public int CurrentQuantity { get; set; }
        public int AdjustmentQuantity { get; set; }
        public int FinalQuantity { get; set; }
    }
}

