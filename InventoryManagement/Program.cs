namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Object Oriented Programs");
            Console.WriteLine("Deck of Cards and Sort by rank Using Queue\n");

            DeckOfCards deckOfCards = new DeckOfCards();
            deckOfCards.CardGame();
        }
    }
}

