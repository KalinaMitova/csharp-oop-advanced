namespace _01HarestingFields
{
    using System;
    using System.Reflection;

    class HarvestingFieldsTest
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();

            Type harvestTest = typeof(HarvestingFields);

            while (input != "HARVEST")
            {
                switch (input)
                {
                    case "public":
                        {
                            PrintPublicFields(harvestTest);
                        }
                        break;

                    case "private":
                        {
                            PrintPrivateFields(harvestTest);
                        }
                        break;

                    case "protected":
                        {
                            PrintProtectedFields(harvestTest);
                        }
                        break;

                    case "all":
                        {
                            PrintAllFields(harvestTest);
                        }
                        break;

                    default:
                        break;
                }

                input = Console.ReadLine().Trim();
            }

        }

        private static void PrintPublicFields(Type harvestTest)
        {
            FieldInfo[] publicFields = harvestTest.GetFields();

            foreach (var field in publicFields)
            {
                Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
            }
        }

        private static void PrintPrivateFields(Type harvestTest)
        {
            FieldInfo[] privateFields = harvestTest.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var field in privateFields)
            {
                if (field.IsPrivate)
                {
                    Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                }
            }
        }

        private static void PrintProtectedFields(Type harvestTest)
        {
            FieldInfo[] privateFields = harvestTest.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var field in privateFields)
            {
                if (field.IsFamily)
                {
                    Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                }
            }
        }

        private static void PrintAllFields(Type harvestTest)
        {
            FieldInfo[] privateFields = harvestTest.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var field in privateFields)
            {
                if (field.IsFamily)
                {
                    Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                }

                else if (field.IsPrivate)
                {
                    Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                }

                else if (field.IsPublic)
                {
                    Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                }
            }
        }
    }
}
