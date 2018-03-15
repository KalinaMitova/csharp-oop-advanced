
namespace _10.ExplicitInterfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Models;
    using Interfaces;

    public class StartUp
    {
        public static void Main()
        {
            List<Citizen> citizens = new List<Citizen>();
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder output = new StringBuilder();

            while (input[0] != "End")
            {
                string name = input[0];
                string country = input[1];
                int age = int.Parse(input[2]);
                Citizen citizen = new Citizen(name, country , age);
                IResident resident = citizen;
                IPerson person = citizen;

                output.AppendLine(person.GetName());
                output.AppendLine(resident.GetName());

                input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.Write(  output.ToString());
        }
    }
}
