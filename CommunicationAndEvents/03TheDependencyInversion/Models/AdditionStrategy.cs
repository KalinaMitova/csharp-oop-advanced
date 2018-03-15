namespace _03TheDependencyInversion.Models
{
    using Interfaces;

    public class AdditionStrategy : IMathOperationStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand + secondOperand;
        }
    }
}
