using System;
using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class ExpenseModel
    {
        [Key]
        public int ExpenseId { get; set; }
        public DateTime DateAdded { get; set; }
        public string ExpenseParticular { get; set; }
        public decimal Amount { get; set; }
        public string Company { get; set; }
        public string ReceiptNumber { get; set; }
        public int RowVersion { get; set; }
    }
}
