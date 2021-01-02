using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    public class GetSumBetweenNumbers
    {
    /*
    * Write a function called GetSumBetweenNumbers that takes in an int min and an int max and returns an int. The function should get the sum of all the numbers between (and including) min and max. The function should solve the problem using iteration.
       * a. If min > max, the function should return 0
    * Write a unit test and test this function.
    * Solve the same problem using recursion and test it again
    */
        public static int GetSumBetweenNumbersIteration(int min, int max)
        {
            int outputSum = 0;
            if (min > max)
            {
                return 0;
            }
            for (int i = min; i <= max; i++)
            {
                outputSum+= i;
            }
            return outputSum;
        }

        public static int GetSumBetweenNumbersRecursion(int min, int max)
        {
            if (min > max)
            {
                return 0;
            }
            else
            {
                return min + GetSumBetweenNumbersRecursion(min + 1, max);
            }

        }

    }
   
}
