using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCalculator
{
    class Multiplication : Operation
    {
        double factorA;
        double factorB;
        public Multiplication(double factorA, double factorB) {
            this.factorA = factorA;
            this.factorB = factorB;
        }

        public double operate() {
            return factorA * factorB;
        }
    }
}
