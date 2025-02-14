
namespace SalesPro.Enums
{
    public enum InventoryAction
    {
        Positive_Adjustment,
        Negative_Adjustment,
        AddedToInventory,
    }

    public enum InventoryFilterType
    {
        All,         // Fetch all inventories
        Active,      // Inventories marked for disposal (define criteria)
        OutOfStock,  // QuantityOnHand == 0
        LowStocks    // QuantityOnHand < threshold
    }
}
