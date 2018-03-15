using System;

namespace _01CardSuit
{
    public class Startup
    {
        public static void Main()
        {
            var suits = Enum.GetValues(typeof(Suit));

            Console.WriteLine("Card Suits:");
            foreach (var item in suits)
            {
                Console.WriteLine($"Ordinal value: {(int)item}; Name value: {item}");
            }
        }
    }
}
