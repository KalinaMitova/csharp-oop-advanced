namespace _10InfernoInfinity.Models
{
    using System;
    using Interfaces;
    using Enums;
    using Weapons;

    public class WeaponFactory
    {
        public IWeapon CreateWeapon(string[] input)
        {
            string[] weaponInfo = input[1].Split();
            string weaponRarityString = weaponInfo[0];
            string weaponType = weaponInfo[1];
            string weaponName = input[2];

            RarityType weaponRarity = (RarityType)Enum.Parse(typeof(RarityType), weaponRarityString);

            switch (weaponType)
            {
                case "Axe":
                        return new Axe(weaponRarity, weaponName);

                case "Sword":
                    return new Sword(weaponRarity, weaponName);

                case "Knife":
                    return new Knife(weaponRarity, weaponName);

                default: throw new OperationCanceledException();
            }
        }
    }
}
