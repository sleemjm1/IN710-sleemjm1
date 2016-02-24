using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestVS2015
{
    public class Hand : IComparable
    {
        public List<Card> CardsInHand { get; set; }
        public int TotalHCP
        {
            get; set;
        }

        public Hand()
        {
            CardsInHand = new List<Card>();
        }

        public void AddCard(Card card)
        {
            CardsInHand.Add(card);
        }

        public int ComputeHCP()
        {
            TotalHCP = 0;
            foreach (Card c in CardsInHand)
                TotalHCP += c.HCP;

            return 0;
        }

        public int CompareTo(object obj)
        {
            Hand otherHand = obj as Hand;
            //return this.TotalHCP.CompareTo(otherHand.TotalHCP);
            int returnCode = this.TotalHCP.CompareTo(otherHand.TotalHCP);
            if (returnCode == -1) return 1;
            else if (returnCode == 1) return -1;
            else return 0;
        }
    }
}