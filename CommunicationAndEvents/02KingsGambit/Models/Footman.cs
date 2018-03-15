namespace _02KingsGambit.Models
{
    using System;

    public class Footman : RoyalRetinue
    {
        private const string ArmyMemberType = "Footman";
        private const int Lifes = 2;

        public Footman(string name)
            : base(name, Lifes)
        {
            base.Type = ArmyMemberType;
        }

        public override void OnKingAtacked(object sender, EventArgs args)
        {
            Console.WriteLine($"{base.Type} {base.Name} is panicking!");
        }
    }
}
