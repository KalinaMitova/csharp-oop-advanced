namespace _10InfernoInfinity.Interfaces
{
    public interface IWeapon
    {
        string Name { get; }

        void AddGemToWeapon(int index, IGem gem);

        void RemoveGemFromWeapon(int index);
    }
}
