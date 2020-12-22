using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Assignment and Increment/decrement
             * 1. Declare integers x and y and initialize them to any values
             * 2. Declare z1 = x++;
             * 3. Declare z2 = ++y;
             * 4. Print the values of x, y, z1, and z2
            */

            //declaration of severral variables at a time
            int x = 6, y = 8;
            int z1 = x++;
            int z2 = ++y;
            Console.WriteLine($"x is {x}, y is {y}, z1 is {z1}, z2 is {z2}");//output is x is 7, y is 9, z1 is 6, z2 is 9

            /*
             * Math
             * 1. Declare integers x, y, and z, and initialize them to any values
             * 2. Declare integers a, b, and c, and initialize them to any combination of math operations using x, y, and z
             * 3. Write an expression that returns true if x is even, and false if x is odd. Store the result of the expression in a bool.
             * 4. Write an expression that returns false if y is divisible by 3. Store the result of the expression in a bool
             * 5. Write an expression that rounds a double to 3 decimal places and store the result in a double.
             */

            int x1 = 2, y1 = 7, z = 8;
            int a = x1 + y1 * z;
            int b = z / x1;
            int c = (z + x1) * y1;
            bool isEven = (x1 % 2) == 0 ? true : false;
            bool notDivisibleBy3 = (y1 % 3) == 0 ? false : true;
            double roundedDouble = Math.Round(4.69069089, 3);
            Console.WriteLine($"a = {a}, b = {b}, c = {c}, isEven = {isEven}, notDivisibleBy3 = {notDivisibleBy3}, roundedDouble = {roundedDouble}");



        }
    }
}
