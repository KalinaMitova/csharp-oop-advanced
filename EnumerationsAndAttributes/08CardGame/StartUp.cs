using System;

namespace _08CardGame
{
    using Models;
    public class StartUp
    {
        public static void Main()
        {
            Player player1 = new Player(Console.ReadLine().Trim());
            Player player2 = new Player(Console.ReadLine().Trim());

            Game game = new Game(player1, player2);

            while (game.Player1CardCount < 5)
            {
                string[] card = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                FillPlayer1Cards(game, card);
            }

            while (game.Player2CardCount < 5)
            {
                string[] card = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                FillPlayer2Cards(game, card);
            }

            Console.WriteLine(game.GetWiner());
        }

        private static void FillPlayer1Cards(Game game, string[] card)
        {
            string rank = card[0];
            string suit = card[2];

            try
            {
                Card newCard = new Card(rank, suit);
                if (!game.IsСssued(newCard))
                {
                    game.AddCardToPlayer1(newCard);
                    game.AddCardToDealtCards(newCard);
                }
                else
                {
                    Console.WriteLine("Card is not in the deck.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No such card exists.");
            }
        }

        private static void FillPlayer2Cards(Game game, string[] card)
        {
            string rank = card[0];
            string suit = card[2];

            try
            {
                Card newCard = new Card(rank, suit);
                if (!game.IsСssued(newCard))
                {
                    game.AddCardToPlayer2(newCard);
                    game.AddCardToDealtCards(newCard);
                }
                else
                {
                    Console.WriteLine("Card is not in the deck.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No such card exists.");
            }
        }

    }
}
