using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class StockPortfolio
    {
        public List<Stock> stocks;
        public StockPortfolio()
        {
            stocks = new List<Stock>();
        }
        public void AddStock(Stock stock)
        {
            stocks.Add(stock);
        }
        public double CalculateTotaValue()
        {
            double totalVal = 0;
            foreach (var stock in stocks)
            {
                totalVal += stock.Calculate();
            }
            return totalVal;
        }
        public void StockReport()
        {
            Console.WriteLine("\nStock Report");

            foreach (var stock in stocks)
            {
                double stockValue = stock.Calculate();
                Console.WriteLine("Stock Name: " + stock.Name);
                Console.WriteLine("Number of shares: " + stock.NumOfShares);
                Console.WriteLine("Share Price: " + stock.SharePrice);
                Console.WriteLine("Total value: " + stockValue);
            }
            double totalValue = CalculateTotaValue();
            Console.WriteLine("Total Portfolio value: " + totalValue);
        }
    }
}
