namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Object Oriented Programs");
            Console.WriteLine("Stock Transction Stack");

            var transactionQueue = new StockTransactionQueue();

            //Add company purchase and sale detail
            transactionQueue.Enqueue("Transaction 1");
            transactionQueue.Enqueue("Transaction 2");
            transactionQueue.Enqueue("Transaction 3");

            transactionQueue.DisplayTransactions();

            //Print the result and show transaction details
            var lastTransaction = transactionQueue.Dequeue();
            Console.WriteLine($"Dequeued transaction: Stock: {lastTransaction.Company}, DateTime Type: {lastTransaction.TransactionDateTime}");
        }
    }
}

