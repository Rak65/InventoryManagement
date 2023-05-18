using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InventoryManagement
{
    public class Stock
    {
        public string Name { get; set; }
        public int NumOfShares { get; set; }
        public double SharePrice { get; set; }
        public double Calculate()
        {
            return NumOfShares * SharePrice;
        }
    }
}
