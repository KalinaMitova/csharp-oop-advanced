namespace _10InfernoInfinity.Models
{
    using Interfaces;
    using Enums;
    using Atrtributes;

    [Autor("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]
    public abstract class Weapon : IWeapon
    {
        private string name;
        private RarityType rarity;
        private Socket sockets;
        private int minDamage;
        private int maxDamage;
        private GemsCollection gems;

        protected Weapon (RarityType rarity, string name, string type, int minDamage, int maxDamage,Socket sockets)
        {
            this.rarity = rarity;
            this.Type = type;
            this.name = name;
            this.Mindamage = minDamage;
            this.Maxdamage = maxDamage;
            this.Sockets = sockets;
            this.gems = new GemsCollection(sockets);
        }

        public virtual int Mindamage
        {
            get { return this.minDamage; }

            protected set { this.minDamage = value * (int)rarity; }
        }

        public virtual int Maxdamage
        {
            get { return this.maxDamage ; }

            protected set { this.maxDamage = value * (int)rarity; }
        }

        public string Type { get; private set; }

        public string Name
        {
            get { return this.name; }

            protected set { this.name = value; }
        }

        public RarityType Rarity
        {
            get { return this.rarity; }

            private set { this.rarity = value; }
        }

        public Socket Sockets
        {
            get { return this.sockets; }

            private set { this.sockets = value; }
        }

        public void AddGemToWeapon(int index, IGem gem)
        {
            this.gems.AddGem(index, gem);
        }

        public void RemoveGemFromWeapon(int index)
        {
            this.gems.RemoveGem(index);
        }

        public override string ToString()
        {
            int totalMinDamage = this.minDamage + this.gems.AllStrength * (int)MagicStateFactor.StrengthMinDamage + this.gems.AllAgility * (int)MagicStateFactor.AgilityMinDamage;
            int totalMaxDamage = this.maxDamage + this.gems.AllStrength * (int)MagicStateFactor.StrengthMaxDamage + this.gems.AllAgility * (int)MagicStateFactor.AgilityMaxDamage;
            return $"{this.Name}: {totalMinDamage}-{totalMaxDamage} Damage, {this.gems.PrintGemsState()}";
        }

    }
}
