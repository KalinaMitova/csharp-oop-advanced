namespace _10InfernoInfinity.Models.Gems
{
    using Interfaces;
    using Enums;

    public abstract class Gem : IGem
    {
        private int strength;
        private int agility;
        private int vitality;

        protected Gem(ClarityLevel clarity, string name,GemStrengthValue strength, GemAgilityValue agility, GemVitalityValue vitality)
        {
            this.Clarity = clarity;
            this.Name = name;
            this.Strength = (int)strength;
            this.Agility = (int)agility;
            this.Vitality = (int)vitality;
        }

        public string Name { get; private set; }

        public ClarityLevel Clarity { get; private set; }

        public int Strength
        {
            get { return this.strength; }

            protected set { this.strength = value + (int) this.Clarity; }
        }

        public int Agility
        {
            get { return this.agility; }

            protected set { this.agility = value + (int) this.Clarity; }
        }

        public int Vitality
        {
            get { return this.vitality; }

            protected set { this.vitality = value + (int)this.Clarity; }
        }

        public override string ToString()
        {
            return $"+{this.Strength} Strength, +{this.Agility} Agility, +{this.Vitality} Vitality";     
        }
    }
}
