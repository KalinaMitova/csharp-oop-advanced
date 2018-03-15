namespace _03TheDependencyInversion.Models
{
    using Interfaces;

    public class DivisionStrategy : IMathOperationStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand / secondOperand;
        }
    }
}
