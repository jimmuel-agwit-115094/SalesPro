using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class Orders : BaseEntity
    {
        [Key]
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierContactPerson { get; set; }
        public string SupplierNumber { get; set; }
        public string SupplierTin { get; set; }
    }
}
