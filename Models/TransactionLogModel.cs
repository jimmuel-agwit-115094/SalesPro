using System;
using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class TransactionLogModel : BaseEntity
    {
        [Key]
        public int TransactionLogId { get; set; }
        public int TransactionId { get; set; }
        public DateTime DateUpdated { get; set; }
        public decimal  BeginningBalance { get; set; }
        public decimal EndingBalance { get; set; }
        public string UserFullname { get; set; }
        public string ActionTaken { get; set; }
    }
}
