using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Stack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();

            string[] input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "Push":
                        {
                            List<int> elements = new List<int>();

                            for (int i = 1; i < input.Length; i++)
                            {
                                elements.Add(int.Parse(input[i]));
                            }

                            myStack.Push(elements.ToArray());
                        }

                        break;

                    case "Pop":
                        {
                            try
                            {
                                myStack.Pop();
                            }
                            catch (OperationCanceledException oe)
                            {
                                Console.WriteLine(oe.Message);
                            }
                        }
                        break;
                }

                input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.Write(myStack.PrintStackTwice());
        }
    }
}
