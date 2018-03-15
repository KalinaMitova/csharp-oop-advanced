using System;

namespace _08.MilitaryElite.Models
{
    public class Mission
    {
        private string codeName;
        private string state;

        public Mission(string codeName, string state)
        {
            this.codeName = codeName;
            this.State = state;
        }

        public string State
        {
            get { return this.state; }

            private set
            {
                if (value != "Finished" && value != "inProgress")
                {
                    throw new ArgumentException();
                }

                this.state = value;
            }
        }

        private bool IsMissionFinished
        {
            get { return this.State == "Finished"; }
        }
      
        public void CompleteMission()
        {
            if (!IsMissionFinished)
            {
                this.State = "Finished";
            }
        }

        public override string ToString()
        {
            return $"Code Name: {this.codeName} State: {this.State}";
        }
    }
}
