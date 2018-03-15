
namespace _01.GenericBoxString
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class StartUp
    {
        public static void Main()
        {
            int numOfRows = int.Parse(Console.ReadLine());
            GenericList<Box<int>> listOfBoxes = new GenericList<Box<int>>();

            for (int i = 0; i < numOfRows; i++)
            {
                int input =int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(input);
                listOfBoxes.Add(box);
            }
            int[] swapIndex = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            listOfBoxes.SwapElement(swapIndex[0], swapIndex[1]);

            Console.Write(listOfBoxes);          
        }

        static int ReturnCountItemGraiterThanGivenEtem<T> (List<T> list, T value )
            where T : IComparable<T>
        {
            int result = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(value) >= 0)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
