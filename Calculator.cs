
#define INCLUDE_ADDITION
#define INCLUDE_DIVISION
#define INCLUDE_SQUAREROOT
#define INCLUDE_CUBE
#define INCLUDE_LOGARITHM
#define INCLUDE_SINE
#define INCLUDE_LISTSUM

using System;
using System.Collections.Generic;
using System.Threading;

namespace Scientificcalculator
{
  public  class Calculator
    {
        Addition add = new Addition();
        Division div = new Division();
        SquareRoot sqrt = new SquareRoot();
        Cube cube = new Cube();
        Logarithm log = new Logarithm();
        Sine sine = new Sine();
        public double PerformCalculation(out string res,string operation, double a, double b =0 )
        {
#if INCLUDE_ADDITION
            if (operation == "add")
            {
                Thread addition = new Thread(new ThreadStart(() => add.Calculate(a, b)));
                addition.Start();
                addition.Join();
                double addresult = add.Calculate(a, b);
                res = $"The sum of {a} and {b} is: {addresult}";
                return addresult;

                //return new Addition().Calculate(a, b);
            }

#endif
#if INCLUDE_DIVISION
            if (operation == "div")
            {
                Thread division = new Thread(new ThreadStart(() => div.Calculate(a, b)));
                division.Start();
                division.Join();
                double divresult = div.Calculate(a, b);
                res=$"The Division of {a} by {b} is : {divresult}";
                return divresult;

                // return new Division().Calculate(a, b);
            }
#endif
#if INCLUDE_SQUAREROOT
            if (operation == "sqrt")
            {
                Thread squareroot = new Thread(new ThreadStart(() => sqrt.Calculate(a)));
                squareroot.Start();
                squareroot.Join();
                double sqrtresult = sqrt.Calculate(a);
                res = $"The Square root of{a} is : {sqrtresult}";
                return sqrtresult;


                //return new SquareRoot().Calculate(a, b);
            }
#endif
#if INCLUDE_CUBE
            if (operation == "cube")
            {

                Thread cubeofno = new Thread(new ThreadStart(() => cube.Calculate(a)));
                cubeofno.Start();
                cubeofno.Join();
                double cuberesult = cube.Calculate(a);
                res = $"The Cube of{a} is : {cuberesult}";
                return cuberesult;

                //return new Cube().Calculate(a, b);
            }
#endif
#if INCLUDE_LOGARITHM
            if (operation == "log")
            {
                Thread logofno = new Thread(new ThreadStart(() => log.Calculate(a)));
                logofno.Start();
                logofno.Join();
                double logresult = log.Calculate(a);
                res = $"The Logarithmic value of{a} is : {logresult}";
                return logresult;

                //return new Logarithm().Calculate(a, b);
            }
#endif
#if INCLUDE_SINE
            if (operation == "sine")
            {
                Thread Sineofno = new Thread(new ThreadStart(() => sine.Calculate(a)));
                Sineofno.Start();
                Sineofno.Join();
                double sineresult = sine.Calculate(a);
                res = $"The Sine value of{a} is : {sineresult}";
                return sineresult;

                //return new Sine().Calculate(a, b);
            }
#endif
            throw new InvalidOperationException("Invalid operation.");
        }
#if INCLUDE_LISTSUM
        public double PerformSumList(out string res,List<int> list)
        {
            double sum = 0;
            foreach (int i in list) { 
            sum += i;
            }
            res = $"The sum of the list of Integers are : {sum}"; 
            return sum;
        }
#endif
    }
    
   }










