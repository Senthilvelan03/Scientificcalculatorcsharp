
using System;
using System.Transactions;

namespace Scientificcalculator
{
    public  abstract class Operation
    {
        public abstract double Calculate(double a, double b = 0);
    }
    
    public  class Addition : Operation
    {
        public override double Calculate(double a, double b)
        {
            double additionresult = a + b;
            Thread.Sleep(1000);
            Console.WriteLine("Addition result will be displayed shortly......");
            return additionresult;
        }
    }

    public class Division : Operation
    {
        public override double Calculate(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by 0 is not possible");
            }
            double divisionresult = a / b;
            Thread.Sleep(1000);
            Console.WriteLine("Division results will be displayed shortly......");

            return divisionresult;
        }
    }

    public class SquareRoot : Operation
    {
        public override double Calculate(double a, double b = 0)
        {
            if (a < 0)
            {
                throw new ArgumentException("Square root for a negative number can't be calculated");
            }
            double squarerootresult = Math.Sqrt(a);
            Thread.Sleep(1000);
            Console.WriteLine("Squareroot of the given number will be displayed shortly......");
            return squarerootresult;
        }
    }

    public class Cube : Operation
    {
        public override double Calculate(double a, double b = 0)
        {
            double cuberesult = Math.Pow(a, 3);
            Thread.Sleep(1000);
            Console.WriteLine("Cube of the given no will be displayed shortly......");
            return cuberesult;
            
        }
    }

    public class Logarithm : Operation
    {
        public override double Calculate(double a, double b = 0)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Logarithm of non-positive number is undefined.");
            }
            double logresult= Math.Log10(a);
            Thread.Sleep(1000);
            Console.WriteLine("Log value of the given no will be displayed shortly......");
            return logresult;
        }
    }

    public class Sine : Operation
    {
        public override double Calculate(double a, double b = 0)
        {
            double Sineresult = Math.Sin(a);
            Thread.Sleep(1000);
            Console.WriteLine("Sine value of the input will be displayed shortly......");
            return Sineresult;
            
        }
    }
}









