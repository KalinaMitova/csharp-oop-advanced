namespace _04WorkForce
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, IEmployee> allEmployees = new Dictionary<string, IEmployee>();
            ListJobs jobs = new ListJobs();

            string[] inputLine = Console.ReadLine().Split();

            while (inputLine[0] != "End")
            {
                string command = inputLine[0];
                switch (command)
                {
                    case "StandartEmployee":
                        {
                            string name = inputLine[1];
                            allEmployees.Add(name, new StandartEmployee(name));
                        }
                        break;

                    case "PartTimeEmployee":
                        {
                            string name = inputLine[1];
                            allEmployees.Add(name, new PartTimeEmployee(name));
                        }
                        break;

                    case "Job":
                        {
                            string nameOfJob = inputLine[1];
                            int hoursOfWorkRequired = int.Parse(inputLine[2]);
                            string employeeName = inputLine[3];
                            Job job = new Job(nameOfJob, hoursOfWorkRequired, allEmployees[employeeName]);
                            job.JobDone += jobs.RemoveJobDone;
                            jobs.Add(job);
                        }
                        break;

                    case "Pass":
                        {
                            List<Job> jobsUpdate = new List<Job>(jobs);
                            foreach (var job in jobsUpdate)
                            {
                                job.Update();
                            }
                        }
                        break;

                    case "Status":
                        foreach (var job in jobs)
                        {
                            Console.WriteLine(job.PrintJobStatus());
                        }

                        break;
                }
                inputLine = Console.ReadLine().Split();
            }
        }
    }
}
