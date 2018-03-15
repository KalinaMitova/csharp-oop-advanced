
namespace _08.MilitaryElite.Models
{
    using Interfaces;
    using System;

    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corpName;
        public SpecialisedSoldier(string id, string firstName, string lastName, double salary, string corpName) 
            : base(id, firstName, lastName, salary)
        {
            this.CorpName = corpName;
        }

        public string CorpName
        {
            get { return this.corpName; }

            private set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException();
                }

                this.corpName = value;
            }
        }

        public override string PrintSoldier()
        {
            return base.PrintSoldier() + $"{Environment.NewLine}Corps: {this.CorpName}";
        }
    }
}
