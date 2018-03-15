namespace _10InfernoInfinity.Models.Gems
{
    using Enums;

    public class Amethyst : Gem
    {
        public Amethyst(ClarityLevel clarity, string name) 
            : base(clarity, name, GemStrengthValue.AmethystStrenght, GemAgilityValue.AmethystAgility, GemVitalityValue.AmethystVitality)
        {
        }
    }
}
