
namespace _08.MilitaryElite.Armys
{
    using System.Collections.Generic;
    using System.Text;
    using Models;
    public class Army
    {
        public List<Soldier> Soldiers { get; private set; }

        public Army()
        {
            this.Soldiers = new List<Soldier>();
        }

        public string PrintArmy()
        {
            StringBuilder output = new StringBuilder();
            this.Soldiers.ForEach(x => output.AppendLine(x.PrintSoldier()));

                return output.ToString();
        }

        public void AddSoldier (Soldier soldier)
        {
            this.Soldiers.Add(soldier);
        }

    }
}
