namespace _02KingsGambit.Models
{
    using System;
    using Interfaces;

    public delegate void ArmyMemberDeathEventHandler (object sender, ArmyMemberDeathEventArgs args);

    public abstract class RoyalRetinue : IRoyalRetinue
    {
        public event ArmyMemberDeathEventHandler ArmyMemberDeath;

        protected RoyalRetinue(string name, int lifes)
        {
            this.Name = name;
            this.AvailableLifes = lifes;
        }

        public string Name { get; private set; }

        public string Type { get; protected set; }

        public int AvailableLifes { get; protected set; }

        protected void OnArmyMemberDeath(ArmyMemberDeathEventArgs args)
        {
            if (ArmyMemberDeath != null)
            {
                ArmyMemberDeath(this, args);
            }
        }

        public abstract void OnKingAtacked(object sender, EventArgs args);


        public virtual void ReactionKingAttaked()
        {
            this.AvailableLifes--;
            if (this.AvailableLifes == 0)
            {
                OnArmyMemberDeath(new ArmyMemberDeathEventArgs( this.Name, OnKingAtacked));
            }       
        }

    }
}
