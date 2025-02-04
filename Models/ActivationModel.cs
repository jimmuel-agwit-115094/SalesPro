using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPro.Models
{
    public class ActivationModel
    {
        [Key]
        public int ActivationId { get; set; }
        public string LicenseKey { get; set; }
        public string SignedKey { get; set; }
        public DateTime DateActivated { get; set; }
        public DateTime DateInstalled { get; set; }
    }
}
