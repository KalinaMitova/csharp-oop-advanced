
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MilitaryElite.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, double salary, string corpName, List<Mission> missions) 
            : base(id, firstName, lastName, salary, corpName)
        {
            this.Missions = missions;
        }

        public List<Mission> Missions { get; private set; }

        public override string PrintSoldier()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(base.PrintSoldier());
            output.Append("Missions:");
            if (this.Missions.Count != 0)
            {
                output.Append($"{Environment.NewLine}  {string.Join($"{Environment.NewLine}  ", this.Missions)}");
            }

            return output.ToString();
                //base.PrintSoldier() + $"{Environment.NewLine}Missions:{Environment.NewLine}  {string.Join($"{Environment.NewLine}  ", this.Missions)}";
        }
    }
}
