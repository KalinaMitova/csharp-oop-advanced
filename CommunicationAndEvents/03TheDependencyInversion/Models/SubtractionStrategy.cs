namespace _03TheDependencyInversion.Models
{
    using Interfaces;

    public class SubtractionStrategy : IMathOperationStrategy
    {
        public int Calculate (int firstOperand, int secondOperand)
        {
            return firstOperand - secondOperand;
        }
    }
}
