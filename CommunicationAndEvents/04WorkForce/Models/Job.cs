namespace _04WorkForce.Models
{
    using System;
    using Interfaces;

    public delegate void JobDoneEventHeadler(object sender, JobDoneEventArgs args);

    public class Job
    {
        public event JobDoneEventHeadler JobDone;
        private string name;
        private int hoursOfWorkRequired;
        private IEmployee employee;

        public Job(string name, int hoursOfWorkRequired, IEmployee employee)
        {
            this.Name = name;
            this.HoursOfWorkRequired = hoursOfWorkRequired;
            this.Employee = employee;
        }

        public string Name
        {
            get { return this.Name; }

            private set { this.name = value; }
        }

        public int HoursOfWorkRequired
        {
            get { return this.hoursOfWorkRequired; }

            private set { this.hoursOfWorkRequired = value; }
        }

        public IEmployee Employee
        {
            get { return this.employee; }

            private set {this.employee = value;}
        }

        protected void OnJobDone (JobDoneEventArgs args)
        {
            if (JobDone != null)
            {
                JobDone(this, args);
            }
        }

        public void Update()
        {
            this.HoursOfWorkRequired -= employee.WeeklyWorkingHour;
            if (IsJobDone)
            {
                Console.WriteLine($"Job {this.name} done!");
                OnJobDone(new JobDoneEventArgs(this));
            }
        }

        private bool IsJobDone => this.hoursOfWorkRequired <= 0;

        public string PrintJobStatus()
        {
            return $"Job: {this.name} Hours Remaining: {this.HoursOfWorkRequired}";
        }
    }
}
