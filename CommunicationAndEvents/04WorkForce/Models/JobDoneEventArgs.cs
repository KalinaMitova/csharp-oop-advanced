using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WorkForce.Models
{
    public class JobDoneEventArgs : EventArgs
    {
        public Job DoneJob { get; }

        public JobDoneEventArgs(Job doneJob)
        {
            this.DoneJob = doneJob;
        }
    }
}
