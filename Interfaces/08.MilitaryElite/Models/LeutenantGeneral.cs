
namespace _08.MilitaryElite.Models
{
    using System;
    using Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(string id, string firstName, string lastName, double salary, List<Soldier> privates) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates = privates;
        }

        public List<Soldier> Privates { get; private set; }

        public override string PrintSoldier()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(base.PrintSoldier());
            output.Append("Privates:");
            if (this.Privates.Count != 0)
            {
                output.Append($"{Environment.NewLine}  {string.Join($"{Environment.NewLine}  ", this.Privates.Select(x => x.PrintSoldier()))}");
            }

            return output.ToString();
                //base.PrintSoldier() + $"{Environment.NewLine}Privates:{Environment.NewLine}  {string.Join($"{Environment.NewLine}  ", this.Privates. Select(x => x.PrintSoldier()))}";
        }
    }
}
