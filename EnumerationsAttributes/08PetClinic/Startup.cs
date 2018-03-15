
namespace _08PetClinic
{
    using System;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            int numOfRows = int.Parse(Console.ReadLine());
            ClinicsNetwork clinicNet = new ClinicsNetwork();

            for (int i = 0; i < numOfRows; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                CommandIterpretor interpretor = new CommandIterpretor(input, clinicNet);
                interpretor.ParseCommand();
            }
        }
    }
}
