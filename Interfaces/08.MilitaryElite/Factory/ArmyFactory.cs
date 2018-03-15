using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.MilitaryElite.Factory
{
    using Armys;
    using Models;
    public class ArmyFactory
    {
        private string input;
        private Army army;

        public ArmyFactory(string input, Army army)
        {
            this.input = input;
            this.army = army;
        }

        public Army ParseCommand()
        {
            string[] inputData = this.input.Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            string soldierType = inputData[0];

            switch (soldierType)
            {
                case "Private":
                   return CreateAndAddPrivateSoldierToArmy(inputData);

                case "LeutenantGeneral":
                    return CreateAndAddLeutenantGeneralToArmy(inputData);

                case "Engineer":
                    return CreateAndAddEngineerToArmy(inputData);

                case "Commando":
                    return CreateAndAddCommandoToArmy(inputData);

                case "Spy":
                    return CreateAndAddSpyToArmy(inputData);

                default:
                    throw new Exception();
            }
        }

        private Army CreateAndAddSpyToArmy(string[] inputData)
        {       
                string id = inputData[1];
                string firstName = inputData[2];
                string lastName = inputData[3];
                string codeNumber = inputData[4];

                this.army.AddSoldier(new Spy(id, firstName, lastName, codeNumber));

            return this.army;
        }

        private Army CreateAndAddCommandoToArmy(string[] inputData)
        { 
                string id = inputData[1];
                string firstName = inputData[2];
                string lastName = inputData[3];
                double salary = double.Parse(inputData[4]);
                string corpsName = inputData[5];
                List<Mission> missions = new List<Mission>();

                for (int i = 6; i < inputData.Length - 1; i += 2)
                {
                    string missionName = inputData[i];
                    string missionState = inputData[i + 1];
                    try
                    {
                        missions.Add(new Mission(missionName, missionState));
                    }
                    catch
                    {
                    }
                }
                this.army.AddSoldier(new Commando(id, firstName, lastName, salary, corpsName, missions));

            return this.army;
        }

        private Army CreateAndAddEngineerToArmy(string[] inputData)
        {

            
                string id = inputData[1];
                string firstName = inputData[2];
                string lastName = inputData[3];
                double salary = double.Parse(inputData[4]);
                string corpsName = inputData[5];
                Dictionary<string, double> repairs = new Dictionary<string, double>();

                for (int i = 6; i < inputData.Length - 1; i += 2)
                {
                string repairName = inputData[i];
                double repairHours = double.Parse(inputData[i + 1]);

                try
                    {
                    
                    repairs.Add(repairName, repairHours);
                    }
                    catch
                    {
                    }
                }
            try
            {
                this.army.AddSoldier(new Engineer(id, firstName, lastName, salary, corpsName, repairs));

            }
            catch { }
            return this.army;
        }

        private Army CreateAndAddLeutenantGeneralToArmy(string[] inputData)
        {         
                string id = inputData[1];
                string firstName = inputData[2];
                string lastName = inputData[3];
                double salary = double.Parse(inputData[4]);

                List<Soldier> privateSoldiers = new List<Soldier>();

                for (int i = 5; i < inputData.Length; i++)
                {
                    string idPrivate = inputData[i];
                    try
                    {
                        privateSoldiers.Add(this.army.Soldiers.Where(s => s.GetType().Name == "Private").First(sid => sid.ID == idPrivate));

                    }
                    catch
                    {
                    }
                }
                this.army.AddSoldier(new LeutenantGeneral(id, firstName, lastName, salary, privateSoldiers));

            return army;
        }

        private Army CreateAndAddPrivateSoldierToArmy(string[] inputData)
        {          
                string id = inputData[1];
                string firstName = inputData[2];
                string lastName = inputData[3];
                double salary = double.Parse(inputData[4]);
                this.army.AddSoldier(new Private(id, firstName, lastName, salary));

            return this.army;
        }
    }
}
