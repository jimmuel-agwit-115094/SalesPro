using SalesPro.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class PaymentLogModel
    {
        [Key]
        public int PaymentLogId { get; set; }
        public int PaymentId { get; set; }
        public DateTime DatePerformed { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string ReferenceNo { get; set; }
        public string OrNumber { get; set; }
        public string Bank { get; set; }
        public string Notes { get; set; }
    }
}
