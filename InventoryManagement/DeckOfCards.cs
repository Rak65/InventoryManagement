using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class DeckOfCards
    {
        public void CardGame()
        {
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            string[,] playersCards = new string[4, 9];

            // Initialize the deck
            string[] deck = new string[52];
            int index = 0;
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    deck[index] = rank + " of " + suit;
                    index++;
                }
            }

            // Shuffle the deck
            Random random = new Random();
            for (int i = deck.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                string temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }

            // Distribute cards to players
            //4 player * 9 cards = 36
            int playerIndex = 0;
            for (int i = 0; i < 36; i++)
            {
                playersCards[playerIndex, i % 9] = deck[i];
                playerIndex = (playerIndex + 1) % 4;
            }

            // Print cards received by each player
            for (int player = 0; player < 4; player++)
            {
                Console.WriteLine("Player {0}:", player + 1);
                for (int card = 0; card < 9; card++)
                {
                    Console.WriteLine(playersCards[player, card]);
                }
                Console.WriteLine();
            }
        }
    }
}