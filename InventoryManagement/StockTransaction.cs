using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class StockTransaction
    {
        public string Symbol { get; set; }
        public TransactionType Type { get; set; }

        public StockTransaction(string symbol, TransactionType type)
        {
            Symbol = symbol;
            Type = type;
        }
    }
    public enum TransactionType
    {
        Purchase,
        Sale
    }
}