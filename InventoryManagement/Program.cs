namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Object Oriented Programs");
            Console.WriteLine("Stock Transction Stack");

            var stockStack = new StockTransactionStack();

            //Add company purchase and sale detail
            stockStack.Push(new StockTransaction("TATA", TransactionType.Purchase));
            stockStack.Push(new StockTransaction("Infosys", TransactionType.Purchase));
            stockStack.Push(new StockTransaction("Reliance", TransactionType.Sale));

            stockStack.DisplayTransactions();

            //Print the result and show transaction details
            var lastTransaction = stockStack.Pop();
            Console.WriteLine($"Popped transaction: Stock: {lastTransaction.Symbol}, Transaction Type: {lastTransaction.Type}");
        }
    }
}

