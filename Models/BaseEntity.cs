using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class BaseEntity
    {
        [ConcurrencyCheck]
        public int RowVersion { get; set; }
    }
}
