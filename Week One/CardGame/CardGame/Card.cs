using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    //public enum Suit { Hearts, Clubs, Spades, Diamonds };
   // public enum Rank { Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13 };
    public class Card
    {
        private string Suit;
        private string Rank;
        
        public Card(string CardSuit, string CardRank)
        {
            Suit = CardSuit;
            Rank = CardRank;
        }

        public bool Compare(string CardToCompare)
        {
            bool CompareResult;
            CompareResult = true;
            return CompareResult;
        }

        public string toString()
        {
            return "hello"
        }
    }
}
