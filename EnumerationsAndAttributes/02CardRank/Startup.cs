using System;

namespace _02CardRank
{
    class Startup
    {
        static void Main(string[] args)
        {
            Array ranks = Enum.GetValues(typeof(CardRank));

            Console.WriteLine("Card Ranks:");

            foreach (var item in ranks)
            {
                Console.WriteLine($"Ordinal value: {(int)item}; Name value: {item}");

            }
        }
    }
}
