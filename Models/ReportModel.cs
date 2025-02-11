using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPro.Models
{
    public class ReportYearModel
    {
        public int Year { get; set; }
        public decimal Total { get; set; }
    }
    public class ReportMonthModel
    {
        public string Month { get; set; }
        public decimal Total { get; set; }
    }
}
