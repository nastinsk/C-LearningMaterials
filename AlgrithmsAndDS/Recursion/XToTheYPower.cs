using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    public class XToTheYPower
    {
        /*
         * Write a function called XToTheYPower that takes in an int x and an int y, and returns int. The function should return x^y. Solve this using iteration, don’t use Math.Pow()
         * Write a unit test and test this function.
         * Solve the same problem using recursion and test it again.
         * 
         * since task asked to return interger from the function we are not covering the case when exponent is negative, which will require to return float numbers
        */

        public static int XToTheYPowerIteration(int x, int y)
        {
            int numPow = 1;
            for (int i = 0; i < y; i++)
            {
                numPow *= x;
            }
            return numPow;
        }

        public static int XToTheYPowerRecursion(int x, int y)
        {
            if(y == 0)
            {
                return 1;
            }
            else
            {
                return x * XToTheYPowerRecursion(x, y - 1);
            }

        }
    }
}
