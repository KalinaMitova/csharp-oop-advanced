using System;

namespace _05ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Town { get; private set; }

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }


        public int CompareTo(Person otherPerson)
        {
            int nameCompare = this.Name.CompareTo(otherPerson.Name);
            int ageCompare = this.Age.CompareTo(otherPerson.Age);

            if (nameCompare != 0 )
            {
                return nameCompare;
            }
            if (ageCompare != 0)
            {
                return ageCompare;
            }

            return this.Town.CompareTo(otherPerson.Town);
        }
        
    }
}
