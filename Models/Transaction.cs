using System;
using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal BeginningBalance { get; set; }
        public decimal TotalSales { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal ExpectedCash { get; set; }
        public decimal EndingCash { get; set; }
        public string OpenedBy { get; set; }
        public string ClosedBy { get; set; }
        public string IsClosed { get; set; }
        public string BalanceStatus { get; set; }
        public long RowVersion { get; set; }
    }
}
