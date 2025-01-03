namespace SalesPro.Enums
{
    public enum OrderStatus
    {
        Active,
        Cancelled,
        Suspended
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
        Cancelled,
        Returned
    }
}
