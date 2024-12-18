namespace SalesPro.Enums
{
    // Note : Dont re-arrange. The order of the tabs in the tab purchase order should match the order of the ProcessStatus enum
    // Adjust both if needed (Purchase Order Tab)
    public enum ProcessStatus
    {
        Created,
        Sent,
        Completed,
        Cancelled,
    }

    public enum PaymentStatus
    {
        Unpaid,
        Partial,
        Paid
    }
}
