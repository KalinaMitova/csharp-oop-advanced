namespace _10InfernoInfinity.Models.Gems
{
    using Enums;

    public class EmptyGem : Gem
    {
        public EmptyGem()
            : base(ClarityLevel.EmptyGem, "Null", 0, 0, 0)
        {
        }
    }
}
