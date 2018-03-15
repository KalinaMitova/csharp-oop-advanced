namespace _02KingsGambit.Models
{
    using System;

    public class RoyalGuard : RoyalRetinue
    {
        private const string ArmyMemberType = "Royal Guard";
        private const int Lifes = 3;

        public RoyalGuard(string name)
            : base(name, Lifes)
        {
            base.Type = ArmyMemberType;
        }

        public override void OnKingAtacked(object sender, EventArgs args)
        {
            Console.WriteLine($"{base.Type} {base.Name} is defending!");
        }
    }
}
