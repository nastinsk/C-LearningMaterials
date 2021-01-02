using System;
using System.Linq;

namespace Recursion
{
    public class ReverseString
    {
        static void Main(string[] args)
        {
            ReverseStringIteration("hello");
            ReverseStringRecursion("hello");
        }

        /*
         * 1. Write a function called ReverseString that takes in a string and returns a string. The function should return the string passed in, but in reverse. The function should solve the problem using iteration.
         * 2. Write a unit test and test this function.
         * 3. Solve the same problem using recursion and test it again.
         */

        //this solution should be O(n) Time and space
        public static string ReverseStringIteration(string inputStr) {

            string[] inputStrArr = inputStr.ToCharArray().Select(c => c.ToString()).ToArray();
            

            for (var i = 0; i < (inputStrArr.Length % 2 == 0 ? inputStrArr.Length / 2: inputStrArr.Length / 2 + 1); i++)
            {
                
                (inputStrArr[i], inputStrArr[inputStrArr.Length - 1 - i]) = (inputStrArr[inputStrArr.Length - 1 - i], inputStrArr[i]);
            }
            
            return String.Join("",inputStrArr);

        }

        public static string ReverseStringRecursion( string inputStr)
        {

            if (inputStr.Length > 0)
            {
                Console.WriteLine(inputStr);
                return inputStr[inputStr.Length - 1] + ReverseStringRecursion(inputStr.Substring(0, inputStr.Length - 1));

            }
            else
            {
                Console.WriteLine(inputStr);

                return inputStr;
            }
                            
        }
    }
}
