using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class StockTransaction
    {
        public string Company { get; set; }
        public DateTime TransactionDateTime { get; set; }

        public StockTransaction(string company)
        {
            TransactionDateTime = DateTime.Now;
            Company = Company;
        }
    }
}