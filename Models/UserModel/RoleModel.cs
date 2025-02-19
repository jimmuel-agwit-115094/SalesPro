using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class RoleModel
    {
        [Key]
        public int RoleId { get; set; }
        public string Role { get; set; }
    }
}
