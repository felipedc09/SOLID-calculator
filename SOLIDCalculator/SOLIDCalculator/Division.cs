using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCalculator
{
    class Division : Operation
    {
        double dividend;
        double divisor;
        public Division(double dividend, double divisor) {
            this.dividend = dividend;
            this.divisor = divisor;
        }

        public double operate() {
            return dividend / divisor;
        }
    }
}
