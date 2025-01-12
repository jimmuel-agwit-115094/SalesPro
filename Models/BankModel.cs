using SalesPro.Enums;

namespace SalesPro.Models
{
    public class BankModel : BaseEntity
    {
        public int BankId { get; set; }
        public string BankName { get; set; }
        public BankType BankType { get; set; }
    }
}
