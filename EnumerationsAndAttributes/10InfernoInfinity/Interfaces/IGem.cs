namespace _10InfernoInfinity.Interfaces
{
    using Enums;
    public interface IGem
    {
        string Name { get; }
        ClarityLevel Clarity { get; }
        int Strength { get; }
        int Agility { get; }
        int Vitality { get; }
    }
}
