using SalesPro.Enums;
using System;
using System.ComponentModel.DataAnnotations;
namespace SalesPro.Models
{
    public class ProductLogModel
    {
        [Key]
        public int ProductLogId { get; set; } 
        public int ProductId { get; set; } 
        public string ProductName { get; set; }
        public ProductActionType ProductActionType { get; set; }
        public string OldValue { get; set; } 
        public string NewValue { get; set; } 
        public string PerformedBy { get; set; } 
        public DateTime DatePerformed { get; set; }
    }
}
