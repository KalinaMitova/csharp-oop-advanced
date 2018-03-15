namespace _10InfernoInfinity.Models.Weapons
{
    using Enums;

    public class Sword : Weapon
    {
        public Sword(RarityType rarity, string name) 
            : base(rarity, name, "Sword", (int) DamageValue.SwordMinDanage, (int) DamageValue.SwordMaxDanage, Socket.SwordSocket)
        {
        }
    }
}
