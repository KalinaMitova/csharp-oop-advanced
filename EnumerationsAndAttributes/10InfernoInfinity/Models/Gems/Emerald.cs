namespace _10InfernoInfinity.Models.Gems
{
    using Enums;

    public class Emerald : Gem
    {
        public Emerald(ClarityLevel clarity, string name) 
            : base(clarity, name,  GemStrengthValue.EmeraldStrenght, GemAgilityValue.EmeraldAgility, GemVitalityValue.EmeraldVitality)
        {
        }
    }
}
