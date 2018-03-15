
namespace _08.MilitaryElite.Models
{
    using System;
    using Interfaces;

    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, string codeNumber) 
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public string CodeNumber { get; private set; }

        public override string PrintSoldier()
        {
            return base.PrintSoldier() + $"{Environment.NewLine}Code Number: {this.CodeNumber.TrimStart('0')}";
        }

    }
}
