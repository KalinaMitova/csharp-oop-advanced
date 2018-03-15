namespace _07._1984.Models
{

    using EventsArgs;

    public class Company : Entity
    {
        private int turnover;
        private int revenue;

        public Company(string id, string name, int turnover, int revenue) 
            : base(id, name)
        {
            this.revenue = revenue;
            this.Turnover = turnover;
        }

        public override string Name
        {
            set
            {
                string oldName = base.Name;
                base.Name = value;

                OnChangeState(new StateChangeEventArgs(this.GetType().Name, this.Id, nameof(Name).ToLower(), this.Name.GetType().Name.ToString(), oldName, value));
            }
        }

        public int Turnover
        {
            get { return this.turnover; }

            set
            {
                int oldTurnover = this.turnover;
                this.turnover = value;
                OnChangeState(new StateChangeEventArgs(this.GetType().Name, this.Id, nameof(Turnover).ToLower(), "int", oldTurnover.ToString(), value.ToString()));
            }
        }

        public int Revenue
        {
            get { return this.revenue; }

            set
            {
                int oldRevenue = this.revenue;
                this.revenue = value;
                OnChangeState(new StateChangeEventArgs(this.GetType().Name, this.Id, nameof(Revenue).ToLower(), "int", oldRevenue.ToString(), value.ToString()));
            }
        }
    }
}
