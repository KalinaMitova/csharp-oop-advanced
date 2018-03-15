using System;
using System.Collections.Generic;
using System.Linq;

namespace _05BorderControl
{
   public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<IEntrants> entrants = new List<IEntrants>();

            while (input != "End")
            {
                string[] entrantsData = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (entrantsData.Length == 3)
                {
                    string name = entrantsData[0];
                    int age = int.Parse(entrantsData[1]);
                    string id = entrantsData[2];

                    Citizen citizen = new Citizen(name, age, id);
                    entrants.Add(citizen);
                }

                else if (entrantsData.Length == 2)
                {
                    string model = entrantsData[0];
                    string id = entrantsData[1];

                    Robot robot = new Robot(model, id);
                    entrants.Add(robot);
                }

                input = Console.ReadLine();
            }

            string lastDigits = Console.ReadLine();

            Console.WriteLine(string.Join("\n", entrants.Where(en => en.ID.EndsWith(lastDigits)).Select(x => x.ID)));
        }
    }
}
