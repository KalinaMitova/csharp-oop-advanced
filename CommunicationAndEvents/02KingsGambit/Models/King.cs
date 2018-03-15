namespace _02KingsGambit.Models
{
    using System;

    public delegate void KingAttackedEventHolder(object sender, EventArgs arg);

    public class King
    {
        public event KingAttackedEventHolder KingAttacked;

        public King(string name)
        {
            this.Name = name;
        }

        public  string Name { get; private set; }

        public void KingMessage()
        {
            Console.WriteLine($"King {this.Name} is under attack!");
            OnKingAttacked(new EventArgs());
        }

        protected void OnKingAttacked(EventArgs arg)
        {
            if (KingAttacked != null)
            {
                KingAttacked(this, arg);
            }
        }

        public void OnArmyMemberDeath (object sender, ArmyMemberDeathEventArgs args)
        {
            this.KingAttacked -= args.RespondMethod;
        }
    }
}
