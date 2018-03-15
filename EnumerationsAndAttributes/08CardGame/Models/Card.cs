using System;

namespace _08CardGame.Models
{
    using Enums;
    public class Card : IComparable<Card>
    {
        private CardRank rank;
        private CardSuit suit;
        private int power;

        public Card(string rank, string suit)
        {
            this.Rank = GetCardRank(rank);
            this.Suit = GetCardSuit(suit);
        }

        public int Power
        {
            get { return (int)this.rank + (int)this.suit; }

            private set
            {
                this.power = (int)this.rank + (int)this.suit;
            }
        }

        private CardRank GetCardRank (string rank)
        {
            return (CardRank)Enum.Parse(typeof(CardRank), rank);
        }

        public CardRank Rank
        {
            get { return this.rank; }

            private set{this.rank = value;}
        }

        public CardSuit Suit
        {
            get { return this.suit; }

            private set { this.suit = value; }
        }
        private CardSuit GetCardSuit(string suit)
        {
            return (CardSuit)Enum.Parse(typeof(CardSuit), suit);
        }

        public  string PrintCard()
        {
            return $"{this.rank} of {this.suit}";
        }

        public int CompareTo(Card other)
        {
            return this.Power.CompareTo(other.Power);
        }
    }
}
