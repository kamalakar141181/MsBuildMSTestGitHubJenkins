using System;

namespace Calculator
{
    public class Operations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to custom calculator!- 18-JUL-2022");
            Console.ReadKey();
        }

        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Substract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double divide(double num1, double num2)
        {
            return num1 / num2;
        }
        public double Multiply(double num1, double num2)
        {
            // To trace error while testing, writing + operator instead of * operator.  
            //return num1 + num2;
            return num1 * num2;
        }
    }
}
