using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class InventoryDetails
    {
        public List<TypeOfRice> typeOfRice;
        public List<TypeOfWheats> typeOfWheats;
        public List<TypeOfPulses> typeOfPulses;
    }
    public class TypeOfRice
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
    }
    public class TypeOfWheats
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
    }
    public class TypeOfPulses
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
    }
}
