using System;

namespace Functions2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4 };
            int[] array2 = { 1, 2, 3, 4 };
            int[] array3 = { 1, 2, 3, 35 };
            int[] array4 = { 1, 2, 3, 35, 34 };

            bool equalArr1And2 = AreArraysEqual(array1, array2);
            Console.WriteLine("is array 1 and 2 equal? " +equalArr1And2);
            bool equalArr2And3 = AreArraysEqual(array2, array3);
            Console.WriteLine("is array 2 and 3 equal? " + equalArr2And3);
            bool equalArr3And4 = AreArraysEqual(array3, array4);
            Console.WriteLine("is array 3 and 4 equal? " + equalArr3And4);
            Console.WriteLine("empty arrays are equal? " + AreArraysEqual(new int[4], new int[4]));


            int abSum, abProduct, abDifference;
            double abQuotient;

            MyMath(3, 7, out abSum, out abDifference, out abProduct, out abQuotient);

            Console.WriteLine(abSum);
            Console.WriteLine(abProduct);
            Console.WriteLine(abDifference);
            Console.WriteLine(abQuotient);


            int index1 = 0;
            int index2 = -4;
            int index3 = 456;
            int index4 = 3;


            char myChar1 = RefChar("Frodo the cat", ref index1);
            Console.WriteLine($"my char1 is {myChar1} index1 is {index1}");

            char myChar2 = RefChar("Frodo the cat", ref index2);
            Console.WriteLine($"my char2 is {myChar2} index2 is {index2}");

            char myChar3 = RefChar("Frodo the cat", ref index3);
            Console.WriteLine($"my char3 is {myChar3} index3 is {index3}");

            char myChar4 = RefChar("Frodo the cat", ref index4);
            Console.WriteLine($"my char4 is {myChar4} index4 is {index4}");
        }

        /*
        * Reference type equality
        * 1. Write a function called AreArraysEqual that returns bool. The function should take in two int arrays and return whether they contain the same elements, in the same order. Call the function to make sure it works.
            * a. The function should return immediately as soon detects a mismatch
        */
        public static bool AreArraysEqual(int[] arr1, int[] arr2)
        {
            try
            {

                for (var i = 0; i < Math.Max(arr1.Length, arr2.Length); i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        return false;
                    }
                }

            }

            catch (IndexOutOfRangeException e)
            {
                return false;
            }

            return true;
        }


        /*
         * Output parameters
         * 1. Write a function that returns void with two int input parameters. The function should have four output parameters that should return the sum, difference, product, and quotient of the two inputs. Call the function to make sure it works.
         */
        public static void MyMath(int a, int b, out int sum, out int difference, out int product, out double quotient)
        {
            sum = a + b;
            difference = a - b;
            product = a * b;
            quotient = a / (double)b;
        }


        /*
         * Reference parameters
         * 1. Write a function that takes in a string and a reference to an int. The function should return the character at the index specified by the int.
            * a. If the int is negative, the first character should be returned and the int should be changed to 0.
            * b. If the int is larger than the string length, the last character should be returned and the int should be changed to the last index in the string.
         */
        public static char RefChar(string userInput, ref int index)
        {
            if (index < 0)
            {
                index = 0;
                return userInput[0];
            }
            if (index > userInput.Length - 1)
            {
                index = userInput.Length - 1;
                return userInput[index];
            }
            return userInput[index];
        }


    }
}
