using System;
using System.Collections.Generic;
using System.Linq;

namespace _01CardSuit
{
    public class StartUp
    {
        public static void Main()
        {
            List<string> createCommand = Console.ReadLine().Split().ToList();
            List<string> collection = new List<string>();

            for (int i = 1; i < createCommand.Count; i++)
            {
                collection.Add(createCommand[i]);
               
            }

            ListyIterator<string> iterator = new ListyIterator<string>(collection);

            string command = Console.ReadLine();

            while (command != "END")
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(iterator.Move().ToString());
                        break;

                    case "HasNext":
                        Console.WriteLine(iterator.HasNext().ToString());
                        break;

                    case "Print":
                        {
                            try
                            {
                                Console.WriteLine(iterator.Print());

                            }
                            catch (OperationCanceledException oe)
                            {
                                Console.WriteLine(oe.Message);
                            }
                        }
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
