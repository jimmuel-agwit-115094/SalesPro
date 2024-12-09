using System;
using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class BaseEntity
    {
        public bool IsDeleted { get; set; }
       
        public int RowVersion { get; set; }
    }
}
