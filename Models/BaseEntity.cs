using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class BaseEntity
    {
        public bool IsDeleted { get; set; }
        [ConcurrencyCheck]
        public int RowVersion { get; set; }
    }
}
