namespace _03BarracksFactory.Core
{
    using System;
    using Contracts;
    using Commands;
    using System.Reflection;
    using System.Globalization;
    using System.Linq;
    using Attributes;

    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }
        
        public void Run()
        {
            string commandsPath = "_03BarracksFactory.Core.Commands.";
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    Type commandType = Type.GetType(commandsPath + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(commandName) + "Command");
                    Type engineType = typeof(Engine);

                    Command command = (Command) Activator.CreateInstance(commandType, new[] { data });
                    //Used when you're not sure what constructor the object  has
                    //ConstructorInfo commandConstructor = commandType.GetConstructor(new[] { typeof(string[]), typeof(IRepository), typeof(IUnitFactory) });
                    //Command command = (Command)commandConstructor.Invoke(new object[] { data, this.repository, this.unitFactory });

                    FieldInfo[] commandFields = commandType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
                    FieldInfo[] engineFields = engineType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

                    foreach (var fieldCommand in commandFields)
                    {
                        Attribute atrInject = fieldCommand.GetCustomAttribute(typeof(InjectAttribute));
                        if (atrInject != null && engineFields.Any(ef => ef.FieldType == fieldCommand.FieldType))
                        {
                            fieldCommand.SetValue(command, engineFields.
                                First(ef => ef.FieldType == fieldCommand.FieldType).
                                GetValue(this));                  
                        }                  
                    }

                    MethodInfo commandMethod = commandType.GetMethod("Execute");

                    string result = (string)commandMethod.Invoke(command, null);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(result);
                }
                catch(TargetInvocationException tex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(tex.InnerException.Message);
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
