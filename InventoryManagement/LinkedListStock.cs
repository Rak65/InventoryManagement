using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class LinkedListStock
    {
        public Node head;
        public void Add(CompanyShares data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }
        public void Remove(CompanyShares data)
        {
            if (head == null)
            {
                return;
            }

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }


        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine($"\nName: {current.Data.Name},    Number of shares: {current.Data.NumOfShares},     Share Price: {current.Data.Price}");
                current = current.Next;
            }
        }
    }
}
