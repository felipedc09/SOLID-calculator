using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCalculator
{
    class Program
    {
        static void Main(string[] args) {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Welcome to the calculator");
            Calculator calculator = new Calculator();
            Operation sum = new Sum(5, 5);
            Operation subtraction = new Subtraction(5, 5);
            Operation multiplication = new Multiplication(5, 5);
            Operation division = new Division(5, 5);
            calculator.getResult(multiplication);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
