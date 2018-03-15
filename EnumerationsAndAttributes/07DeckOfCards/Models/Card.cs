using System;

namespace _07DeckOfCards.Models
{
    using Enums;
    public class Card : IComparable<Card>
    {
        private CardRank rank;
        private CardSuit suit;
        private int power;

        public Card(string rank, string suit)
        {
            this.rank = GetCardRank(rank);
            this.suit = GetCardSuit(suit);
        }


        private CardRank GetCardRank (string rank)
        {
            return (CardRank)Enum.Parse(typeof(CardRank), rank);
        }

        private CardSuit GetCardSuit(string suit)
        {
            return (CardSuit)Enum.Parse(typeof(CardSuit), suit);
        }

        public int Power
        {
            get { return (int)this.rank + (int)this.suit; }

            private set
            {
                this.power = (int)this.rank + (int)this.suit;
            }
        }

        public override string ToString()
        {
            return $"Card name: {this.rank} of {this.suit}; Card power: {this.Power}";
        }

        public int CompareTo(Card other)
        {
            return this.Power.CompareTo(other.Power);
        }
    }
}
