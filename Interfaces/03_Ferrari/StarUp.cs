using System;

namespace _03_Ferrari
{
  public class StarUp
    {
        public static void Main()
        {
            string driverName = Console.ReadLine().Trim();
            Ferrari ferrary = new Ferrari(driverName);

            Console.WriteLine($"{Ferrari.Model}/{ferrary.Brakes()}/{ferrary.Gas()}/{driverName}");

            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }

        }
    }
}
