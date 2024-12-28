namespace SalesPro.Models
{
    public class TransactionSession
    {
        public static int _transactionId { get; private set; }

        public static void SetTransactionId(int transaction_id)
        {
            _transactionId = transaction_id;
        }
    }
}
