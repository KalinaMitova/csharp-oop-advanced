using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MilitaryElite.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, double salary, string corpName, Dictionary<string, double> repairs) 
            : base(id, firstName, lastName, salary, corpName)
        {
            this.Repairs = repairs;
        }

        public Dictionary<string, double> Repairs { get; private set; }

        public override string PrintSoldier()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(base.PrintSoldier());
            output.Append("Repairs:");
            if (this.Repairs.Count != 0)
            {
                output.Append($"{Environment.NewLine}  {string.Join($"{Environment.NewLine}  ", this.Repairs.Select(x => $"Part Name: {x.Key} Hours Worked: {x.Value}"))}");
            }
            return output.ToString();
                //base.PrintSoldier() + $"{Environment.NewLine}Repairs:{Environment.NewLine}  {string.Join($"{Environment.NewLine}  ", this.Repairs.Select(x => $"Part Name: {x.Key} Hours Worked: {x.Value}"))}";
        }
    }
}
