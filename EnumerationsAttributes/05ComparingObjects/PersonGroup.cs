using System.Collections.Generic;


namespace _05ComparingObjects
{
   public class PersonGroup
    {
        List<Person> group;

        public PersonGroup()
        {
            this.group = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            this.group.Add(person);
        }

        public string HasEqualPerson(int index)
        {
            Person personTarget = this.group[index-1];

            int equalPersons = 0;

            foreach (var person in group)
            {
                if (person.CompareTo(personTarget) == 0)
                {
                    equalPersons++;
                }
            }

            if (equalPersons > 1)
            {
                return $"{equalPersons} {this.group.Count - equalPersons} {this.group.Count}";
            }
            else
            {
                return $"No matches";
            }
        }
    }
}
