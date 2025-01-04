using SalesPro.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class CustomerCreditModel
    {
        [Key]
        public int CustomerCreditId { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal CreditAmount { get; set; }
        public int CreditTerms { get; set; }
        public DateTime CreditedDate { get; set; }
        public DateTime DueDate { get; set; }
        public string InvoiceNumber { get; set; } 
        public PaymentStatus PaymentStatus { get; set; }
        public string Notes { get; set; }
        public int RowVersion { get; set; } 
    }

}
