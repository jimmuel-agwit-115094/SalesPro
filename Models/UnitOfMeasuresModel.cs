using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPro.Models
{
    public class UnitOfMeasuresModel
    {
        [Key]
        public int UnitOfMeasureId { get; set; }
        public string UnitName { get; set; }
    }
}
