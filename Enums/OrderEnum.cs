namespace SalesPro.Enums
{
    public enum OrderStatus
    {
        Active,
        Suspended,
        Completed,
        Cancelled,
    }

    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        DebitCard,
        Cheque,
        BankTransfer,
        NotSet
    }

    public enum OrderItemStatus
    {
        Added,
        Returned
    }

    public enum OrderAction
    {
        New,
        Return,
        Inquiry
    }

    public enum SearchByAction
    {
        Barcode,
        ProductName,
        AllProducts
    }
}
