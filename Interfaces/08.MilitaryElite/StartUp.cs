
namespace _08.MilitaryElite
{
    using Armys;
    using System;
    using Factory;
    public class StartUp
    {
        public static void Main()
        {
            Army army = new Army();

            string input = Console.ReadLine();

            while (input != "End")
            {
                    ArmyFactory factory = new ArmyFactory(input, army);
                    army = factory.ParseCommand();
               
                input = Console.ReadLine();
            }

            Console.Write(army.PrintArmy());
        }
    }
}
 