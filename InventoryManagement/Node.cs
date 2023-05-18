using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InventoryManagement
{
    public class Node
    {
        public CompanyShares Data;
        public Node Next;
        public Node(CompanyShares data)
        {
            Data = data;
            this.Next = Next;
        }
    }
}
