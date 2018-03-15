namespace _03BarracksFactory.Core.Commands
{
    using Contracts;
    using Attributes;

    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repo;

        public RetireCommand(string[] data) 
            : base(data)
        {
        }

        public override string Execute()
        {
                string unitType = base.Data[1];
                this.repo.RemoveUnit(unitType);
                return unitType + " retired!";        
        }
    }
}
