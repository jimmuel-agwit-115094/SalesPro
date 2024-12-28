using SalesPro.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class OrderModel : BaseEntity
    {
        [Key]
        public int OrderId { get; set; }
        public int TransactionId { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateTaken { get; set; }
        public decimal Total { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal Vat { get; set; }
        public decimal NetAmount { get; set; }
        public decimal VatAmount { get; set; }
        public decimal AmountDue { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Change { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public bool IsCredited { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime? DatePaid { get; set; }
    }

    public class OrderModelExtended : OrderModel
    {
        public string CustomerName { get; set; }
        public string UserName { get; set; }
    }
}
