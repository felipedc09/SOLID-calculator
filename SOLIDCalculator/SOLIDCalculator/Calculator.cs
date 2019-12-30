
using System;

namespace SOLIDCalculator
{
    class Calculator
    {
        public Calculator() {

        }

        public void getResult(Operation operation) {
            double result = operation.operate();
            Console.WriteLine(string.Format("The result from {0} is: {1}", operation.GetType().Name, result));
        }
    }
}
