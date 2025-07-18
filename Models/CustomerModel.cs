﻿using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class CustomerModel : BaseEntity
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
    }

    public class ReportCustomerExtended : CustomerModel
    {
        public string FullName { get; set; }
        public decimal TotalAmountPaid { get; set; }
    }
}
