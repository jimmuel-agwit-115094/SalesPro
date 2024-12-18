using SalesPro.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class PurchaseOrderLogsModel : BaseEntity
    {
        [Key]
        public int PurchaseOrderLogsId { get; set; }
        public int PurchaseOrderId { get; set; }
        public int UserId { get; set; }
        public ProcessStatus ProcessStatus { get; set; }
        public DateTime Date { get; set; }
    }
}
