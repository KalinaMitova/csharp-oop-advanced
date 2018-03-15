using System;

namespace _06CustomEnumAttribute
{
    using Enums;
    public class Startup
    {
        public static void Main()
        {
            //string typeName = Console.ReadLine().Trim();

            //if (typeName == "Rank")
            //{
            //    Type type = typeof(CardRank);

            //    object[] allAtributes = type.GetCustomAttributes(false);

            //    foreach (TypeAttribute attr in allAtributes)
            //    {
            //        Console.WriteLine(attr);
            //    }
            //}
            //else if(typeName == "Suit")
            //{
            //    Type type = typeof(CardSuit);

            //    object[] allAtributes = type.GetCustomAttributes(false);

            //    foreach (TypeAttribute attr in allAtributes)
            //    {
            //        Console.WriteLine(attr);
            //    }
            //}

            string command = Console.ReadLine().Trim().ToLower();

            Type type = typeof(Weapon);
            object[] allAtributes = type.GetCustomAttributes(false);

            while (command != "end")
            {
                switch (command)
                {
                    case "author":
                        {
                            foreach (AutorAttribute item in allAtributes)
                            {
                                //Console.WriteLine($"Author: {item.author}");
                                Console.WriteLine(item.author);
                            }
                        }  break;

                    case "revision":
                        {
                            foreach (AutorAttribute item in allAtributes)
                            {
                                //Console.WriteLine($"Revision: {item.revision}");
                                Console.WriteLine(item.revision);
                            }
                        }
                        break;

                    case "description":
                        {
                            foreach (AutorAttribute item in allAtributes)
                            {
                                //Console.WriteLine($"Class description: {item.description}");
                                Console.WriteLine(item.description);
                            }
                        }
                        break;

                    case "reviewers":
                        {
                            foreach (AutorAttribute item in allAtributes)
                            {
                               //Console.WriteLine($"Reviewers: {string.Join(", ", item.reviewers)}");
                                Console.WriteLine(string.Join(", ", item.reviewers));
                            }
                        }
                        break;
                }
                command = Console.ReadLine().Trim().ToLower();
            }
        }
    }
}
