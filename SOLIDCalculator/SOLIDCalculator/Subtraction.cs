using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCalculator
{
    class Subtraction : Operation
    {
        double minuend;
        double subtrahend;
        public Subtraction(double minuend, double subtrahend) {
            this.minuend = minuend;
            this.subtrahend = subtrahend;
        }

        public double operate() {
            return minuend - subtrahend;
        }
    }
}
