using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public class Calculator
    {
        private double result;

        public double GetResult
        {
            get { return result; }
            set { result = value; }
        }

        public void AllClear()
        {
            result = 0;
        }

        public double Add(double a, double b)
        {
            result = a + b;
            return result;
        }

        public double Substract(double a, double b)
        {
            result = a - b;
            return result;
        }

        public double Multiply(double a, double b)
        {
            result = a * b;
            return result;
        }

        public double Divison(double a, double b)
        {
            result = a / b;
            return result;
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}