using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class StockTransactionQueue
    {
        private LinkedList<StockTransaction> queue;

        //Create list of stock transaction
        public StockTransactionQueue()
        {
            queue = new LinkedList<StockTransaction>();
        }


        //Add purchase transaction
        public void Enqueue(string company)
        {
            var transaction = new StockTransaction(company);
            queue.AddLast(transaction);
        }

        //Remove last transaction and gives final transaction status
        public StockTransaction Dequeue()
        {
            if (queue.Count == 0)
                throw new InvalidOperationException("Queue is empty.");

            var lastTransaction = queue.First.Value;
            queue.RemoveFirst();
            return lastTransaction;
        }

        public void DisplayTransactions()
        {
            foreach (var transaction in queue)
            {
                Console.WriteLine($"Transaction: {transaction.Company} - DateTime: {transaction.TransactionDateTime}");
            }
        }
    }
}
