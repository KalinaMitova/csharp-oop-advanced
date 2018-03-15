namespace _01EventImplementation
{
    using System;

    public class Startup
    {
         public static void Main()
        {
            Dispatcher dispatcher = new Dispatcher();

            Handler handler = new Handler();

            dispatcher.NameChange += handler.OnDispatcherNameChange;

            string nameInput = Console.ReadLine();

            while (nameInput != "End")
            {
                dispatcher.Name = nameInput;
                nameInput = Console.ReadLine();
            }      
        }
    }
}
