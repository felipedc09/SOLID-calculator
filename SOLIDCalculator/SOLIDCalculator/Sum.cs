
namespace SOLIDCalculator
{
    class Sum : Operation
    {
        double addendA;
        double addendB;
        public Sum(double addendA, double addendB) {
            this.addendA = addendA;
            this.addendB = addendB;
        }
        public double operate() {
           return addendA + addendB;
        }
    }
}
