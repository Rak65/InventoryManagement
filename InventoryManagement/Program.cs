namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Object Oriented Programs");
            Console.WriteLine("Stock LinkedList");

            LinkedListStock sharesList = new LinkedListStock();

            // Adding company shares
            Console.WriteLine("We get shares data of companies: ");
            var share1 = new CompanyShares("TATA", 20, 100);
            var share2 = new CompanyShares("Infosys", 50, 200);
            var share3 = new CompanyShares("Wipro", 40, 300);


            sharesList.Add(share1);
            sharesList.Add(share2);
            sharesList.Add(share3);
            sharesList.Display();

            // Removing company shares
            sharesList.Remove(share1);
            Console.WriteLine("\nAfter removed data: \n");

            // Printing the remaining shares
            sharesList.Display();
        }
    }
}

