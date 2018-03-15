namespace _02KingsGambit
{
    using System;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
           ModifiedDictionary armyMembers = new ModifiedDictionary();

            string kingName = Console.ReadLine();

            King king = new King(kingName);

            string[] royalGuardNames = Console.ReadLine().Split();
            string[] footmanNames = Console.ReadLine().Split();

            foreach (var name in royalGuardNames)
            {
                armyMembers.Add(name, new RoyalGuard(name));
                armyMembers[name].ArmyMemberDeath += armyMembers.HandlerArmyMemberDeath;
                armyMembers[name].ArmyMemberDeath += king.OnArmyMemberDeath;
                king.KingAttacked += armyMembers[name].OnKingAtacked;
            }
            foreach (var name in footmanNames)
            {
                armyMembers.Add(name, new Footman(name));
                armyMembers[name].ArmyMemberDeath += armyMembers.HandlerArmyMemberDeath;
                armyMembers[name].ArmyMemberDeath += king.OnArmyMemberDeath;
                king.KingAttacked += armyMembers[name].OnKingAtacked;
            }

            string[] commandInput = Console.ReadLine().Split();

            while (commandInput[0] != "End")
            {
                string command = commandInput[0];

                switch (command)
                {
                    case "Kill":
                        {
                            string name = commandInput[1];
                            RoyalRetinue memberRemoved = armyMembers[name];
                            memberRemoved.ReactionKingAttaked();
                        }
                        break;

                    case "Attack":
                        {
                            king.KingMessage();
                        }
                        break;
                }

                commandInput = Console.ReadLine().Split();
            }

        }
    }
}
