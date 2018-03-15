using System;
using System.Collections.Generic;

namespace _06StrategyPattern
{
    class Startup
    {
        static void Main()
        {
            SortedSet<Person> personByName = new SortedSet<Person>(new PersonCompererByName());
            SortedSet<Person> personByAge = new SortedSet<Person>(new PersonCompererByAge());

            int numOfRows = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < numOfRows; i++)
            {
                string[] personData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = personData[0]; 
                int age = int.Parse(personData[1]);

                personByAge.Add(new Person(name, age));
                personByName.Add(new Person(name, age));
            }

            Console.WriteLine(string.Join($"{Environment.NewLine}", personByName));
            Console.WriteLine(string.Join($"{Environment.NewLine}", personByAge));
        }

        public class PersonCompererByName : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                int nameCompare = x.Name.Length.CompareTo(y.Name.Length);
                if (nameCompare != 0)
                {
                    return nameCompare;
                }

                return x.Name.ToLower()[0].CompareTo(y.Name.ToLower()[0]);
            }
        }

        public class PersonCompererByAge : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return x.Age.CompareTo(y.Age);
            }
        }
    }
}
