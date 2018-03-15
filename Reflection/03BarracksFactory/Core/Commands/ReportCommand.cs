namespace _03BarracksFactory.Core.Commands
{
    using Contracts;
    using Attributes;

    public class ReportCommand : Command
    {
        [Inject]
        private IRepository repo;

        public ReportCommand(string[] data) 
            : base(data)
        {
        }

        public override string Execute()
        {
            return this.repo.Statistics;
        }
    }
}
