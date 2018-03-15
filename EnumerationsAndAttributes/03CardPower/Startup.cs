using System;

namespace _03CardPower
{
    using Models;
    public class Startup
    {
        static void Main()
        {
            string rankCard1 = Console.ReadLine().Trim();
            string suitCard1 = Console.ReadLine().Trim();

            Card card = new Card(rankCard1, suitCard1);

            string rankCard2 = Console.ReadLine().Trim();
            string suitCard2 = Console.ReadLine().Trim();

            Card card2 = new Card(rankCard2, suitCard2);

            if (card.CompareTo(card2) > 1)
            {
                Console.WriteLine(card);
            }
            else
            {
            Console.WriteLine(card2);
            }
        }
    }
}
