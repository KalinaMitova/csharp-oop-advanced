using System.Collections.Generic;
using System.Linq;

namespace _08CardGame.Models
{
    public class Player
    {
        private string name;
        private SortedSet<Card> cards;

        public Player (string name)
        {
            this.Name = name;
            this.cards = new SortedSet<Card>();
        }

        public string Name
        {
            get { return this.name; }

            private set { this.name = value; }
        }

        public Card maxPowerCard => this.cards.Last();

        public int Count => this.cards.Count;

        public void AddCard (Card card)
        {
            this.cards.Add(card);
        }

        public string PrintPlayer()
        {
            return (this.Name);
        }
    }
}
