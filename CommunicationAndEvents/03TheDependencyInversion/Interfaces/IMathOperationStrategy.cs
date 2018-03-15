using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03TheDependencyInversion.Interfaces
{
    public interface IMathOperationStrategy
    {
        int Calculate(int firstOperand, int secondOperand);
    }
}
