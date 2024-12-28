namespace SalesPro.Enums
{
    public enum OrderStatus
    {
        Active,
        Cancelled
    }

    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        DebitCard,
        Cheque,
        BankTransfer
    }

    public enum OrderItemStatus
    {
        Added,
        Cancelled,
        Returned
    }
}
