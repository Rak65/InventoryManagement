using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class StockTransactionStack
    {
        private LinkedList<StockTransaction> transactions;

        //Create list of stock transaction
        public StockTransactionStack()
        {
            transactions = new LinkedList<StockTransaction>();
        }


        //Add purchase transaction
        public void Push(StockTransaction transaction)
        {
            transactions.AddLast(transaction);
        }

        //Pop last transaction and gives final transaction status
        public StockTransaction Pop()
        {
            if (transactions.Count == 0)
                throw new InvalidOperationException("Stack is empty.");

            var lastTransaction = transactions.Last.Value;
            transactions.RemoveLast();
            return lastTransaction;
        }

        public void DisplayTransactions()
        {
            foreach (var transaction in transactions)
            {
                Console.WriteLine($"Stock: {transaction.Symbol}, Transaction Type: {transaction.Type}");
            }
        }
    }
}
