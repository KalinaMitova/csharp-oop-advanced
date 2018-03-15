using System;

namespace _09LinkedListTraversal
{
    public class Startup
    {
        public static void Main()
        {
            LinkedList<int> myList = new LinkedList<int>();

            int numOfRows = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfRows; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (input[0] )
                {
                    case "Add":
                        myList.Add(int.Parse(input[1]));
                        break;

                    case "Remove":
                        myList.Remove(int.Parse(input[1]));
                        break;
                }
            }
            Console.WriteLine(myList.Count);
            foreach (var value in myList)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
