
namespace _07DeckOfCards
{
    using System;
    using Enums;
    public class Startup
    {
        public static void Main()
        {
            string command = Console.ReadLine();

            if (command == "Card Deck")
            {
                foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
                {
                    foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
                    {
                        Console.WriteLine($"{rank} of {suit}");
                    }
                }
            }
        }
    }
}
