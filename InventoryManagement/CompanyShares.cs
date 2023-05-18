using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class CompanyShares
    {
        public string Name { get; set; }
        public int NumOfShares { get; set; }
        public double Price { get; set; }
        public CompanyShares(string name, int numOfShares, double price)
        {
            Name = name;
            NumOfShares = numOfShares;
            Price = price;
        }
    }
}
