
namespace _07.CustomList
{
    using System;

    public class CommondInterpreter
    {
        private string input;
        private CustomList<string> list;

        public CommondInterpreter(string input, CustomList<string> list)
        {
            this.input = input;
            this.list = list;
        }

        public void ParseCommand()
        {
            string[] inputDetails = this.input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string command = inputDetails[0];

            switch (command)
            {
                case "Add":
                    {
                        string element = inputDetails[1];
                        this.list.Add(element);
                    }
                    break;

                case "Remove":
                    {
                        int index = int.Parse(inputDetails[1]);
                        this.list.Remove(index);
                    }
                    break;

                case "Contains":
                    {
                        string element = inputDetails[1];
                        OutputWriter.PrintOutputOnNewLine(this.list.Contains(element).ToString());
                    }
                    break;

                case "Swap":
                    {
                        int index1 = int.Parse(inputDetails[1]);
                        int index2 = int.Parse(inputDetails[2]);
                        this.list.Swap(index1, index2);
                    }
                    break;
                
                case "Greater":
                    {
                        string element = inputDetails[1];
                        OutputWriter.PrintOutputOnNewLine(this.list.CountGreaterThan(element).ToString());
                    }
                    break;

                case "Max":
                    {
                        OutputWriter.PrintOutputOnNewLine(this.list.Max().ToString());
                    }
                    break;

                case "Min":
                    {
                        OutputWriter.PrintOutputOnNewLine(this.list.Min().ToString());
                    }
                    break;

                case "Sort":
                    {
                       Sorter.Sort(this.list);
                    }
                    break;

                case "Print":
                    OutputWriter.PrintOutput(this.list.PrintList());
                    break;

                default:
                    break;
            }
        }
    }
}
