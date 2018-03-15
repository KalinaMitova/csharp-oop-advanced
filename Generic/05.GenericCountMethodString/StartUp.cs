
namespace _05.GenericCountMethodString
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            int numOfRows = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();

            for (int i = 0; i < numOfRows; i++)
            {
                double input = double.Parse(Console.ReadLine());
                //string input = Console.ReadLine();
                list.Add(input);
            }
            double stringCompare = double.Parse(Console.ReadLine());
            Console.WriteLine(ReturnCountItemGraiterThanGivenEtem(list, stringCompare));
        }

        static int ReturnCountItemGraiterThanGivenEtem<T>(List<T> list, T value)
           where T : IComparable<T>
        {
            int result = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(value) > 0)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
