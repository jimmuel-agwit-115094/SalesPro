namespace SalesPro.Enums
{
    public enum OrderStatus
    {
        Active,
        Suspended,
        Completed
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

    public enum OrderAction
    {
        New,
        Return
    }
}
