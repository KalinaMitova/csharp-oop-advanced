
namespace _09.CollectionHierarchy
{
    using System;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(" ", addCollection.Add(input))); 
            Console.WriteLine(string.Join(" ", addRemoveCollection.Add(input))); 
            Console.WriteLine(string.Join(" ", myList.Add(input)));

            int countRemove = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", myList.Remove(countRemove)));
            Console.WriteLine(string.Join(" ", addRemoveCollection.Remove(countRemove)));
        }
    }
}
