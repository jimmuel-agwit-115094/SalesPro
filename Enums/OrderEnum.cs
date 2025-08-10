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
        EPayment,
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
        Inquiry,
        AddByPrice
    }

    public enum SearchByAction
    {
        Barcode,
        ProductName,
        AllProducts
    }
}
