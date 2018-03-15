
namespace _08.MilitaryElite.Models
{
    using System;
    using Interfaces;

    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string lastName, double salary) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public double Salary { get; private set; }

        public override string PrintSoldier()
        {
            return base.PrintSoldier() + $" Salary: {this.Salary:F2}";
        }
    }
}
