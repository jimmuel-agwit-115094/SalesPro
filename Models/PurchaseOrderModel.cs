using SalesPro.Enums;
using System;
using System.ComponentModel.DataAnnotations;


namespace SalesPro.Models
{
    public class PurchaseOrderModel : BaseEntity
    {
        [Key]
        public int PurchaseOrderId { get; set; }
        public int SupplierId { get; set; }
        public int UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DueDate { get; set; }
        public int CreditTerms { get; set; }
        public decimal PoTotal { get; set; }
        public ProcessStatus ProcessStatus { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public string CancellationReason { get; set; }
        public string Remarks { get; set; }
    }

    public class PurchaseOrderModelExtended : PurchaseOrderModel
    {
        public string SupplierName { get; set; }
        public string UserName { get; set; }
    }
}
