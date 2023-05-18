namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Object Oriented Programs");
            Console.WriteLine("Stock Account Management");

            Console.Write("Enter number of stocks: ");
            int numStocks = Convert.ToInt32(Console.ReadLine());

            StockPortfolio stockPortfolio = new StockPortfolio();

            for (int i = 0; i < numStocks; i++)
            {
                Console.WriteLine("Stocks: " + (i + 1));
                Console.Write("Enter Stock name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Number of share: ");
                int numOfShares = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter share price: ");
                double sharePrice = Convert.ToDouble(Console.ReadLine());

                Stock stock = new Stock();
                stock.Name = name;
                stock.NumOfShares = numOfShares;
                stock.SharePrice = sharePrice;

                stockPortfolio.AddStock(stock);
            }
            stockPortfolio.StockReport();
        }
    }
}

