using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10InfernoInfinity
{
    using Interfaces;
    using Enums;
    using Models;
    using Models.Weapons;
    using Models.Gems;

    public class Startup
    {
        public static void Main()
        {
            Dictionary<string, IWeapon> weapons = new Dictionary<string, IWeapon>();

            Type type = typeof(Weapon);
            object[] allAtributes = type.GetCustomAttributes(false);

            string[] input = Console.ReadLine()
                .Split(new[] { ';'}, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                CommandInterpreter interpreter = new CommandInterpreter(input, weapons,allAtributes);
                interpreter.ParseCommand();

                input = Console.ReadLine().Split(new[] { ';'}, StringSplitOptions.RemoveEmptyEntries);
            }

        }
    }
}
