namespace _10InfernoInfinity.Models.Weapons
{
    using Enums;
    public class Knife : Weapon
    {
        public Knife(RarityType rarity, string name) 
            : base(rarity, name, "Knife", (int) DamageValue.KnifeMinDanage, (int)DamageValue.KnifeMAxDanage, Socket.KnifeSocket)
        {
        }
    }
}
