namespace _10InfernoInfinity.Models.Weapons
{
    using Enums;
    public class Axe : Weapon
    {
        public Axe(RarityType rarity, string name) 
            : base(rarity, name, "Axe", (int) DamageValue.AxeMinDanage, (int)DamageValue.AxeMaxDanage, Socket.AxeSocket)
        {
        }
    }
}
