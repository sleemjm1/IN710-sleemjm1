using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bridge
{
    

    class TCard
    {
        private int Suit;
        private int CardValue;

        public TCard(int Suit, int CardValue)
        {
            this.Suit = Suit;
            this.CardValue = CardValue;

        }

        public int suit
        {
            get
            {
                return Suit;
            }
            set
            {
                Suit = value;
            }
        }
        public int cardValue
        {
            get
            {
                return CardValue;
            }
            set
            {
                CardValue = value;
            }
        }

        public override string ToString()
        {
            return "TCard toString";
        }
    }

    class TDeck
    {
        private TCard[] Cards;

        public const int TOTALCARDS = 52;
        public const int CARDSPERSUIT = 13;

        public TDeck()
        {
            Cards = new TCard[TOTALCARDS];
            int Suit = -1;
            int CardValue = 0;

            for (int i = 0; i < Cards.Length; i++)
            {
                if (i % CARDSPERSUIT == 0) Suit++;
                CardValue = i % CARDSPERSUIT;
                Cards[i] = new TCard(Suit, CardValue);         
            }
        }

        public void shuffle()
        {
            Random RanNum = new Random();
            int SwapIndex;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < Cards.Length; j++)
                {
                    SwapIndex = RanNum.Next(Cards.Length);
                    TCard Temp = Cards[i];
                    Cards[i] = Cards[SwapIndex];
                    Cards[SwapIndex] = Temp;
                }
            }
        }

        public void Deal(THand[] Hands)
        {

            int HandNum = 0;
            int CardNum = 0;
            TCard[] TempHand = new TCard[CARDSPERSUIT];

            for (int i = 0; i < Cards.Length; i++)
            {
                Hands[HandNum].cards[CardNum] = Cards[i];
                CardNum++;
                if ((i + 1) % CARDSPERSUIT == 0)
                {
                    CardNum = 0;
                    HandNum++;
                }   
            }
        }

    }

    class THand
    {
        private TCard[] Cards;
        private ListBox DisplayBox;
        private string[] CardValues;
        private string[] CardSuits;

        public const int CARDSPERSUIT = 13;

        public THand(ListBox DisplayBox)
        {
            Cards = new TCard[CARDSPERSUIT];
            this.DisplayBox = DisplayBox;
            CardValues = new string[13]{"2","3","4","5","6","7","8","9","T","J","Q","K","A"};
            CardSuits = new string[4] { "S", "H", "C", "D"};
        }

        public void DispayHand()
        {
            DisplayBox.Items.Add("------------------------");
            string SpadesString = "S:\t";
            string HeartsString = "H:\t";
            string DiamondsString = "D:\t";
            string ClubsString = "C:\t";
            for (int i = 0; i < Cards.Length; i++)
            {
                if (CardSuits[Cards[i].suit].Equals("S"))
                {
                    SpadesString += CardValues[Cards[i].cardValue];
                }
                if (CardSuits[Cards[i].suit].Equals("H"))
                {
                    HeartsString += CardValues[Cards[i].cardValue];
                }
                if (CardSuits[Cards[i].suit].Equals("D"))
                {
                    DiamondsString += CardValues[Cards[i].cardValue];
                }
                if (CardSuits[Cards[i].suit].Equals("C"))
                {
                    ClubsString += CardValues[Cards[i].cardValue];
                }
                //string OutputString = CardSuits[Cards[i].suit] + " " + CardValues[Cards[i].cardValue];
            }
            DisplayBox.Items.Add(SpadesString);
            DisplayBox.Items.Add(HeartsString);
            DisplayBox.Items.Add(DiamondsString);
            DisplayBox.Items.Add(ClubsString);            
            DisplayBox.Items.Add("------------------------");
            DisplayBox.Items.Add("HCP: " + CalcScore());
            DisplayBox.Items.Add("");
        }

        public int CalcScore()
        {
            int Score = 0;

            for (int i = 0; i < Cards.Length; i++)
            {
                switch(Cards[i].cardValue)
                {
                    case 9:
                        Score += 1;
                        break;
                    case 10:
                        Score += 2;
                        break;
                    case 11:
                        Score += 3;
                        break;
                    case 12:
                        Score += 4;
                        break;
                    default:
                        Score += 0;
                        break;
                        
                }
            }

            return Score;
        }

        public TCard[] cards
        {
            set
            {
                Cards = cards;
            }
            get
            {
                return this.Cards;
            }
        }

        public void SortHand()
        {
            TCard temp;

            for (int i = (Cards.Length - 1); i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (Cards[j - 1].suit > Cards[j].suit)
                    {
                        temp = Cards[j - 1];
                        Cards[j - 1] = Cards[j];
                        Cards[j] = temp;
                    }

                }
            }
            for (int i = (Cards.Length - 1); i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if ((Cards[j - 1].suit == Cards[j].suit)&&(Cards[j - 1].cardValue < Cards[j].cardValue))
                    {
                        temp = Cards[j - 1];
                        Cards[j - 1] = Cards[j];
                        Cards[j] = temp;
                    }

                }
            }
        }

    }
}
