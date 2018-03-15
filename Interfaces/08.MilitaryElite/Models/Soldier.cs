
namespace _08.MilitaryElite.Models
{
    using System;
    using Interfaces;

    public abstract class Soldier : ISoldier
    {
        public Soldier(string id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;    
        }

        public string ID { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public virtual string PrintSoldier()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.ID}";
        }
    }
}
