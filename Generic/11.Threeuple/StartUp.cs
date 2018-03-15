using System;

namespace _11.ClassThreeuple
{
    public class StartUp
    {
        public static void Main()
        {
           
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = $"{input[0]} {input[1]}";
            string address = input[2];
            string town = input[3];
            Threeuple<string, string,string> threeuple = new Threeuple<string, string, string>(name, address,town);
            Console.WriteLine($"{threeuple.Item1} -> {threeuple.Item2} -> {threeuple.Item3}"); 

            input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            name = input[0];
            int beerCout = int.Parse(input[1]);
            string drunkOrNot = input[2];

            bool isDrunk = drunkOrNot == "drunk";
            var threeuple2 = new Threeuple<string, int, bool>(name, beerCout, isDrunk);
            Console.WriteLine($"{threeuple2.Item1} -> {threeuple2.Item2} -> {threeuple2.Item3}");

            input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            name = input[0];
            double double2 = double.Parse(input[1]);
            string nameBank = input[2];

            Threeuple<string, double, string> threeuple3 = new Threeuple<string, double,string>(name, double2, nameBank);
            Console.WriteLine($"{threeuple3.Item1} -> {threeuple3.Item2:F1} -> {threeuple3.Item3}");

        }
    }
}
