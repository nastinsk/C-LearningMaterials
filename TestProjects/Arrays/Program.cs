using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Single dimensional arrays
             * 1. Create an int array of size 10. Use a while loop to fill the array with the numbers 1 through 10.
             * 2. Use a for loop to print the contents of the array in reverse order.
             * 3. Write code that prints the sum of all numbers in the array
             * 4. Print the contents of the array without using a loop
             */

            //Another ways to declare int array:
            //var numArray = new int[] { 1, 2, 3, 4, 5 };
            //var numArray = new int[5] { 1, 2, 3, 4, 5 };

            int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int arraySum = 0;

            for (int i = numArray.Length - 1; i >= 0; i--)
            {
                arraySum += numArray[i];
                Console.WriteLine(numArray[i]);
            }
            Console.WriteLine(arraySum);

            string arrayContents = string.Join(",", numArray);
            Console.WriteLine(arrayContents);

            /* 
             * Multi-dimensional arrays
             * 1. Create a 2D int array of any size
             * 2. Use any loop(s) to store the product of the two indices in each element
                * a. For example, the element at [2,3] should be set to 6
             * 3. Print the contents of the array using a foreach loop
             */

            var my2DArray = new int[6, 6];

            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    my2DArray[i, j] = i * j;
                }
            }

            foreach (int el in my2DArray)
            {
                Console.WriteLine(el);
            }
        }
    }
}
