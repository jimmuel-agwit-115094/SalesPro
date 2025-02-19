using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class UserAccessModel
    {
        [Key]
        public int UserAccessId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public UserModel User { get; set; }
        public RoleModel Role { get; set; }
    }
}
