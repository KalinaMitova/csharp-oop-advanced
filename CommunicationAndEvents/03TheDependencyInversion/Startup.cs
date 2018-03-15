namespace _03TheDependencyInversion
{
    using System;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            PrimitiveCalculator calculator = new PrimitiveCalculator();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                if (input[0] == "mode")
                {
                    string symbolStrategy = input[1];
                    switch (symbolStrategy)
                    {
                        case "+":
                            calculator.ChangeStrategy(new AdditionStrategy());
                            break;
                        case "-":
                            calculator.ChangeStrategy(new SubtractionStrategy());
                            break;
                        case "*":
                            calculator.ChangeStrategy(new MultiplicationStrategy());
                            break;
                        case "/":
                            calculator.ChangeStrategy(new DivisionStrategy());
                            break;
                    }
                }
                else
                {
                    int firstOperand = int.Parse(input[0]);
                    int secondOperand = int.Parse(input[1]);

                    Console.WriteLine(calculator.PerformCalculation(firstOperand, secondOperand));
                }

                input = Console.ReadLine().Split();
            }
        }
    }
}
