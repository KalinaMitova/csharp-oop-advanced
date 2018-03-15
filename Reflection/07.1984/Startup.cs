namespace _07._1984
{
    using System;
    using Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class Startup
    {
        public static void Main()
        {
            Dictionary<string,Entity> entities = new Dictionary<string, Entity>();
            List<Institution> institutions = new List<Institution>();

            int[] inputInfo = Console.ReadLine().Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int numberOfEntities = inputInfo[0];
            int numberOfInstitutions = inputInfo[1];
            int numberOfChanges = inputInfo[2];

            for (int i = 0; i < numberOfEntities; i++)
            {
                string[] entityInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string typeName = entityInfo[0];
                switch (typeName)
                {
                    case "Employee":
                        entities.Add(entityInfo[1], new Employee(entityInfo[1], entityInfo[2], int.Parse(entityInfo[3])));
                        break;

                    case "Company":
                        entities.Add(entityInfo[1], new Company(entityInfo[1], entityInfo[2], int.Parse(entityInfo[3]), int.Parse(entityInfo[4])));
                        break;
                }
            }

            for (int i = 0; i < numberOfInstitutions; i++)
            {
                string[] institutionInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string[] param = new string[institutionInfo.Length-3];
                for (int j = 3; j < institutionInfo.Length; j++)
                {
                    param[j - 3] = institutionInfo[j];
                }

                institutions.Add(new Institution(institutionInfo[1], institutionInfo[2], param));
            }

            foreach (var ent in entities)
            {
                foreach (var inst in institutions)
                {
                    ent.Value.ChangeName += inst.ChangeNameAction;
                }
            }

            for (int i = 0; i < numberOfChanges; i++)
            {
                string[] changeInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string id = changeInfo[0];
                string fieldName = changeInfo[1];
                string newValue = changeInfo[2];

                switch (fieldName)
                {
                    case "name":
                        entities[id].Name = newValue;
                        break;

                    case "income":
                        try
                        {
                            (entities[id] as Employee).Income = int.Parse(newValue);
                        }
                        catch { }
                        break;

                    case "turnover":
                        try
                        {
                            (entities[id] as Company).Turnover = int.Parse(newValue);
                        }
                        catch { }
                        break;

                    case "revenue":
                        try
                        {
                            (entities[id] as Company).Revenue = int.Parse(newValue);
                        }
                        catch { }
                        break;
                }
            }

            foreach (var inst in institutions)
            {
                Console.Write(inst);
            }
        }
    }
}
