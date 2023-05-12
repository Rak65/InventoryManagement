namespace InventoryManagement
{
    class Program
    {
        public static void Main(String[] args)
        {
            string path = "H:\\C# Project\\InventoryManagement\\InventoryManagement\\Inventory.json";
            ReadTheData readTheData = new ReadTheData();

            InventoryDetails data = readTheData.Read(path);

            for (int i = 0; i < data.typesOfRice.Count; i++)
            {

                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine(data.typesOfRice[i].price);
            }

            foreach (var inventory in data.typesOfRice)
            {
                Console.WriteLine(inventory.name);
            }
        }
    }
}

