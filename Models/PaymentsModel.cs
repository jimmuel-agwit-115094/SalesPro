using SalesPro.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class PaymentsModel : BaseEntity
    {
        [Key]
        public int PaymentId { get; set; }
        public int ReferenceId { get; set; }

        public int OrderId { get; set; }
        public PaymentType PaymentType { get; set; }
        public string UserName { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string ReferenceNumber { get; set; }
        public string OrNumber { get; set; }
        public string BankName { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Notes { get; set; }
    }
}
