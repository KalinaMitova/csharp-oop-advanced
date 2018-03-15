using System.Collections.Generic;

namespace _08CardGame.Models
{
   public class Game
    {
        private Player player1;
        private Player player2;
        private HashSet<Card> dealtCards;

        public Game(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.dealtCards = new HashSet<Card>(new CardCompererForHashSet());
        }

        public bool IsСssued (Card card) => this.dealtCards.Contains(card);

        public void AddCardToDealtCards(Card card)
        {
            this.dealtCards.Add(card);
        }

        public void AddCardToPlayer1 (Card card)
        {
            this.player1.AddCard(card);
        }

        public int Player1CardCount => this.player1.Count;

        public int Player2CardCount => this.player2.Count;

        public void AddCardToPlayer2(Card card)
        {
            this.player2.AddCard(card);
        }

        public string GetWiner()
        {
            Player winner = player1;
            if (player1.maxPowerCard.CompareTo(player2.maxPowerCard) < 0)
            {
                winner = player2;
            }
            return $"{winner.PrintPlayer()} wins with {winner.maxPowerCard.PrintCard()}.";
        }

        private class CardCompererForHashSet : IEqualityComparer<Card>
        {
            public bool Equals(Card x, Card y) => (x.Rank.CompareTo(y.Rank) == 0 && x.Suit.CompareTo(y.Suit) == 0);

            public int GetHashCode(Card card)
            {
                return card.Rank.GetHashCode();
            }
        }

        
    }
}
