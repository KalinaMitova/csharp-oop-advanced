using System;
using System.Linq;

namespace _04.Froggy
{
    class Startup
    {
        static void Main()
        {
            int[] input = Console.ReadLine().
                Split(new[] { ',' , ' '}, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            Lake lake = new Lake(input);
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
