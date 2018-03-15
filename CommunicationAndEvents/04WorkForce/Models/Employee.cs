namespace _04WorkForce.Models
{
    using Interfaces;

    public abstract class Employee : IEmployee
    {
        private string name;
        private int weeklyWorkingHour;

        protected Employee(string name, int weeklyWorkingHour)
        {
            this.Name = name;

            this.WeeklyWorkingHour = weeklyWorkingHour;
        }

        public string Name
        {
            get { return this.name;}

            protected set { this.name = value; }
        }

        public int WeeklyWorkingHour
        {
            get  { return this.weeklyWorkingHour; }

            protected set { this.weeklyWorkingHour = value; }
        }

    }
}
