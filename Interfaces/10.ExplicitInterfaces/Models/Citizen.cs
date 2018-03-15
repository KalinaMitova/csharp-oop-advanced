
namespace _10.ExplicitInterfaces.Models
{
    using System;
    using Interfaces;

    public class Citizen : IResident, IPerson
    {
        private string name;
        private string country;
        private int age;

        public Citizen (string name, string country, int age)
        {
            this.Name = name; this.Country = country;
            this.Age = age;
        }

        public string Country
        {
            get { return this.country; }

            private set { this.country = value; }
        }

        public string Name
        {
            get { return this.name; }

            private set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }

            private set { this.age = value; }
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }

        string IPerson.GetName()
        {
           return$"{this.Name}";

        }
    }
}
