using SalesPro.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesPro.Helpers
{
    public class InventoryHelper
    {
        public static List<InventoryFilterType> GetInventoryFilterTypes()
        {
            return Enum.GetValues(typeof(InventoryFilterType))
                       .Cast<InventoryFilterType>()
                       .Where(x => x != InventoryFilterType.AllProducts)
                       .ToList();
        }
    }
}
