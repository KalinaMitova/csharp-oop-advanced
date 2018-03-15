using System;

namespace _05ComparingObjects
{
    class Starup
    {
        static void Main(string[] args)
        {
            PersonGroup group = new PersonGroup();
            string[] personData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (personData[0] != "END")
            {
                string name = personData[0];
                int age = int.Parse(personData[1]);
                string town = personData[2];

                group.AddPerson(new Person(name, age, town));

                personData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            int index = int.Parse(Console.ReadLine().Trim());

            Console.WriteLine(group.HasEqualPerson(index));
        }
    }
}
