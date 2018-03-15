namespace _03BarracksFactory.Core.Commands
{
    using Contracts;
    using Attributes;

    public class AddCommand : Command
    {
        [Inject]
        private IRepository repo;
        [Inject]
        private IUnitFactory factory;

        public AddCommand(string[] data) 
            : base(data)
        {
        }

        public override string Execute()
        {
            string unitType = base.Data[1];
            IUnit unitToAdd = this.factory.CreateUnit(unitType);
            this.repo.AddUnit(unitToAdd);
            return unitType + " added!";
        }
    }
}
