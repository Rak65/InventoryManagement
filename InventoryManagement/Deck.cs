using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Deck
    {
        public Card[] _cards;
        public int _currentIndex;

        public Deck()
        {
            _cards = new Card[52];
            _currentIndex = 0;

            int index = 0;
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    _cards[index++] = new Card(suit, rank);
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            for (int i = _cards.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = _cards[i];
                _cards[i] = _cards[j];
                _cards[j] = temp;
            }
        }

        public Card Deal()
        {
            if (_currentIndex >= _cards.Length)
            {
                return null;
            }

            Card card = _cards[_currentIndex];
            _currentIndex++;
            return card;
        }
    }
    public class Player
    {
        public string Name { get; }
        public Queue<Card> _cards;

        public Player(string name)
        {
            Name = name;
            _cards = new Queue<Card>();
        }

        public void ReceiveCard(Card card)
        {
            _cards.Enqueue(card);
        }

        public void SortCardsByRank()
        {
            Card[] cards = new Card[_cards.Count];
            int index = 0;
            while (_cards.Count > 0)
            {
                cards[index++] = _cards.Dequeue();
            }

            Array.Sort(cards, (card1, card2) => card1.Rank.CompareTo(card2.Rank));

            for (int i = 0; i < cards.Length; i++)
            {
                _cards.Enqueue(cards[i]);
            }
        }

        public void PrintCards()
        {
            Console.WriteLine($"{Name}'s cards:");
            foreach (Card card in _cards)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine();
        }
    }

    public class DeckOfCards
    {
        public void CardGame()
        {
            // Create the deck and shuffle it
            Deck deck = new Deck();
            deck.Shuffle();

            // Create players
            Player[] players = new Player[4];
            players[0] = new Player("Player 1");
            players[1] = new Player("Player 2");
            players[2] = new Player("Player 3");
            players[3] = new Player("Player 4");

            // Distribute 9 cards to each player
            for (int i = 0; i < 9; i++)
            {
                foreach (Player player in players)
                {
                    Card card = deck.Deal();
                    player.ReceiveCard(card);
                }
            }

            // Sort the players' cards by rank
            foreach (Player player in players)
            {
                player.SortCardsByRank();
            }

            // Print the players and their cards using a 2D array
            string[,] cardsArray = new string[players.Length, 9];

            for (int i = 0; i < players.Length; i++)
            {
                int j = 0;
                foreach (Card card in players[i]._cards)
                {
                    cardsArray[i, j] = card.ToString();
                    j++;
                }
            }

            for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine($"Player {i + 1}'s cards:");
                for (int j = 0; j < 9; j++)
                {
                    Console.WriteLine(cardsArray[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}