﻿using System;

namespace Calculator
{
    public class Operations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to custom calculator - updated to validate auto build - DUMMY PUSH after 192.168.0.103 ip address added in github");            
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
