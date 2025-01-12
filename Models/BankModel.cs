using SalesPro.Enums;
using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class BankModel : BaseEntity
    {
        [Key]
        public int BankId { get; set; }
        public string BankName { get; set; }
        public BankType BankType { get; set; }
    }
}
