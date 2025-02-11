using System.ComponentModel.DataAnnotations;

namespace SalesPro.Models
{
    public class ProductModel : BaseEntity
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string BarCode { get; set; }
        public string UnitOfMeasure { get; set; }
        public string Description { get; set; }
        public int ReorderLevel { get; set; }
    }

    public class ReportProductExtended : ProductModel
    {
        public int TotalProductOrdered { get; set; }
    }
}
