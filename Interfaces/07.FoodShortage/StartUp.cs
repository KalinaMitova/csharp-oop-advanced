
namespace _07.FoodShortage
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Models;
    public class StartUp
    {
        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            Dictionary<string,IBuyer> people = new Dictionary<string, IBuyer>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] peopleInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (peopleInfo.Length == 4)
                {
                    string name = peopleInfo[0];
                    int age = int.Parse(peopleInfo[1]);
                    string id = peopleInfo[2];
                    string birthday = peopleInfo[3];

                    Citizen citizen = new Citizen(name, age, id, birthday);
                    people.Add(name, citizen);
                }

                else if (peopleInfo.Length == 3)
                {
                    string name = peopleInfo[0];
                    int age = int.Parse(peopleInfo[1]);
                    string group = peopleInfo[2];

                    Rebel rebel = new Rebel(name, age, group);
                    people.Add(name, rebel);
                }
            }

            string buyerName = Console.ReadLine().Trim();
            while (buyerName != "End")
            {
                try
                {
                    people[buyerName].BuyFood();
                }
                catch
                {
                }

                buyerName = Console.ReadLine().Trim();
            }

            int totalFood = 0; 

            foreach (var kvp in people)
            {
                totalFood += kvp.Value.Food;
            }

            Console.WriteLine(totalFood);
        }
    }
}
