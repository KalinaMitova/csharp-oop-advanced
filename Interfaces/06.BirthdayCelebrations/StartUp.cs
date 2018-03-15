
namespace _06.BirthdayCelebrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<IBirthdatable> entrants = new List<IBirthdatable>();

            while (input != "End")
            {
                string[] entrantsData = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (entrantsData.Length == 5)
                {
                    string name = entrantsData[1];
                    int age = int.Parse(entrantsData[2]);
                    string id = entrantsData[3];
                    string birthdate = entrantsData[4];

                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    entrants.Add(citizen);
                }

                else if (entrantsData.Length == 3 && input.Contains('/'))
                {
                    string name = entrantsData[1];
                    string birthdate = entrantsData[2];

                    Pet pet = new Pet(name, birthdate);
                    entrants.Add(pet);
                }

                input = Console.ReadLine().Trim();
            }

            string specificYear = Console.ReadLine();

            Console.WriteLine(string.Join("\n", entrants.Where(en => en.Birthdate.EndsWith(specificYear)).Select(x => x.Birthdate)));
        }
    }
}
