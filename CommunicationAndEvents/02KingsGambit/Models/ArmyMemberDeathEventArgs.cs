namespace _02KingsGambit.Models
{
    using System;
   
    public class ArmyMemberDeathEventArgs : EventArgs
    {
        public ArmyMemberDeathEventArgs(string name,KingAttackedEventHolder respondMethod)
        {
            this.Name = name;
            this.RespondMethod = respondMethod;
        }

        public string Name { get; private set; }

        public KingAttackedEventHolder RespondMethod { get; private set; }
    }
}