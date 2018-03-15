namespace _02BlackBoxInteger
{
    using System;
    using System.Reflection;

    class BlackBoxIntegerTests
    {
        static void Main()
        {
            Type blackBoxType = typeof(BlackBoxInt);

            ConstructorInfo constructor = blackBoxType.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, Type.EmptyTypes, null);

            BlackBoxInt box = (BlackBoxInt)constructor.Invoke(null);

           

            string[] inputLine = Console.ReadLine().Split(new[] {'_'});

            while (inputLine[0] != "END")
            {
                string operation = inputLine[0];
                int num = int.Parse(inputLine[1]);

                MethodInfo blakcBoxMethod = blackBoxType.GetMethod(operation, BindingFlags.NonPublic | BindingFlags.Instance, null, new[] { typeof(int) }, null);

                blakcBoxMethod.Invoke(box, new object[] { num });

                FieldInfo blackBoxTypeField = blackBoxType.GetField("innerValue", BindingFlags.NonPublic | BindingFlags.Instance);

                int value = (int)blackBoxTypeField.GetValue(box);

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(value);

                Console.ForegroundColor = ConsoleColor.Gray;
                inputLine = Console.ReadLine().Split(new[] { '_' });
            }
           
        }
    }
}
