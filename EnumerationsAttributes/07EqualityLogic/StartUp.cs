using System;
using System.Collections.Generic;

namespace _07EqualityLogic
{
    class StartUp
    {
        static void Main(string[] args)
        {
            SortedSet<Person> personSortedSet = new SortedSet<Person>(new PersonCompererByNameAndAge());
            HashSet<Person> personHashSet = new HashSet<Person>(new PersonCompererForHashSet());

            int numOfRows = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < numOfRows; i++)
            {
                string[] personData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = personData[0];
                int age = int.Parse(personData[1]);

                personHashSet.Add(new Person(name, age));
                personSortedSet.Add(new Person(name, age));
            }

            Console.WriteLine(personSortedSet.Count);
            Console.WriteLine(personHashSet.Count);
        }

        public class PersonCompererByNameAndAge : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                int nameCompare = x.Name.CompareTo(y.Name);
                if (nameCompare != 0)
                {
                    return nameCompare;
                }

                return x.Age.CompareTo(y.Age);
            }
        }

        public class PersonCompererForHashSet : IEqualityComparer<Person>
        {
            public bool Equals(Person x, Person y) => (x.Name.CompareTo(y.Name) == 0 && x.Age.CompareTo(y.Age) == 0);

            public int GetHashCode(Person person)
            {
                return person.Name.GetHashCode(); 
            }
        }
    }
}
