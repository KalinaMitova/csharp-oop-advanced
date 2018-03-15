using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WorkForce.Models
{
    public class ListJobs : List<Job>
    {
        public void RemoveJobDone(object sender, JobDoneEventArgs args)
        {
            this.Remove(args.DoneJob);
        }
    }

}
