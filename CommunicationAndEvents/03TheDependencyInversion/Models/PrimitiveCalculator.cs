namespace _03TheDependencyInversion
{
    using Interfaces;
    using Models;

    public class PrimitiveCalculator
    {
        public  IMathOperationStrategy Strategy { get; private set; }

        public PrimitiveCalculator()
        {
            this.Strategy = new AdditionStrategy();
        }

        public PrimitiveCalculator(IMathOperationStrategy strategy)
        {
            this.Strategy = strategy;
        }

        public void ChangeStrategy(IMathOperationStrategy strategy)
        {
            this.Strategy = strategy;
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            return this.Strategy.Calculate(firstOperand, secondOperand);
        } 
    }
}
