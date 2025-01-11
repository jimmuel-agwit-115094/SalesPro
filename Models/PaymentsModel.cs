using SalesPro.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class PaymentsModel
    {
        [Key]
        public int PaymentId { get; set; }
        public int ReferenceId { get; set; }
        public PaymentType PaymentType { get; set; }
        public int UserId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string ReferenceNumber { get; set; }
        public string OrNumber { get; set; }
        public int BankId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Notes { get; set; }
        public int RowVersion { get; set; }
    }
}
