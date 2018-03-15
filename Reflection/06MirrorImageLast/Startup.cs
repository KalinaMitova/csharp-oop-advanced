namespace _06MirrorImageLast
{
    using System;
    using Models;

    public class Startup
    {
        
        public static void Main()
        {
            string[] wizardRootinfo = Console.ReadLine().Split();
            WizardTree tree = new WizardTree(new BasicWizard($"{wizardRootinfo[0]}", int.Parse(wizardRootinfo[1])));

            while (true)
            {
                string[] inputLine = Console.ReadLine().Split();

                if (inputLine[0] == "END")
                {
                    Environment.Exit(0);
                    break;
                }

                string command = inputLine[1];
                int index = int.Parse(inputLine[0]);

                switch (command)
                {
                    case "FIREBALL":
                        tree.FireballAction(index);
                        break;

                    case "REFLECTION":
                        tree.ReflestionAction(index);
                        break;
                }

            }
        }
    }
}
