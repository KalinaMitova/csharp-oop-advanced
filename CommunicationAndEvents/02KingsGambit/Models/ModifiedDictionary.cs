namespace _02KingsGambit.Models
{
    using System.Collections.Generic;


    public class ModifiedDictionary : Dictionary<string, RoyalRetinue>
    {
        public void HandlerArmyMemberDeath (object sender, ArmyMemberDeathEventArgs args)
        {
            this.Remove(args.Name);
        }
    }
}
