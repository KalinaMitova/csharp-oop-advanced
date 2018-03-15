namespace _07._1984.Models
{
    using EventsArgs;

    public class Employee : Entity
    {
        private int income;


        public Employee(string id, string name, int income) 
            : base(id, name)
        {
            this.Income = income;
        }
        
        public int Income
        {
            get { return this.income; }

            set
            {
                int oldIncome = this.income;
                this.income = value;
                OnChangeState(new StateChangeEventArgs(this.GetType().Name, this.Id, nameof(Income).ToLower(), "int", oldIncome.ToString(), value.ToString()));
            }
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
    }
}
