using System;

namespace _10.Tuple
{
    public class StartUp
    {
        public static void Main()
        {
           
            string[] input = Console.ReadLine().Split();
            string name = $"{input[0]} {input[1]}";
            string address = input[2];
            Tuple<string, string> tuple = new Tuple<string, string>(name, address);
            Console.WriteLine(tuple);

            input = Console.ReadLine().Split();
            name = input[0];
            int beerCout = int.Parse(input[1]);
            var tuple2 = new Tuple<string, int>(name, beerCout);
            Console.WriteLine(tuple2);

            input = Console.ReadLine().Split();
            int integer = int.Parse(input[0]);
            double double2 = double.Parse(input[1]);
            Tuple<int, double> tuple3 = new Tuple<int, double>(integer, double2);
            Console.WriteLine(tuple3);


        }
    }
}
