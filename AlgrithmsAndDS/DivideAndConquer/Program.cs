using System;
using System.Collections.Generic;

namespace DivideAndConquer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        /*
         * 1. Write a function called MultiplyList that takes in a List<int>. It should return the product of all numbers in the list. Solve this problem using iteration.
         * 2. Write a unit test and test this function.
         * 3. Solve the same problem using a recursive divide-and-conquer algorithm and test it again.
         */
        public static int MultiplyListIretaion(List<int> inputList)
        {

            int product=0;

            if(inputList.Count > 0)
            {
                product = 1;
                foreach (int el in inputList)
                {
                    product *= el;
                }
                return product;
            }

            return product;
        }

        public static int MultiplyListDivideAndConquer(List<int> inputList)
        {
        
            if(inputList.Count == 0)
            {
                return 0;
            }
            if(inputList.Count == 1)
            {
                return inputList[0];
            }
            else
            {
                return inputList[0] * MultiplyListDivideAndConquer(inputList.GetRange(1, inputList.Count - 1));
            }
        }
    }
}
