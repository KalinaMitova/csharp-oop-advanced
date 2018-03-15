namespace _03TheDependencyInversion.Models
{
    using Interfaces;

    public class MultiplicationStrategy : IMathOperationStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand * secondOperand;
        }
    }
}
