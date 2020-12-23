using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * If/else
             * 1. Create an int x and set it to 1
             * 2. Write an if/else if/else statement that will check if x is less than, equal to, or greater than 100 and print an appropriate message for each case
             * 3. Change the value of x to cause each case to be triggered
             */
            var rand = new Random();
            int x = rand.Next(200);
            
            if (x < 100)
            {
                Console.WriteLine($"x is {x} less than 100");
            }
            else if(x == 100)
            {
                Console.WriteLine($"x is {x} less equal to 100");
            }
            else
            {
                Console.WriteLine($"x is {x} greater than 100");
            }

            /*
             * Switch
             * 1. Create an enum type. Name it whatever you like and populate it with whatever values you like.
             * 2. Write a switch statement that checks each value of the enum and does something for each match.
             * Include one case that falls through to the next case.
             */
            var color = Colors.Orange;

            switch (color)
            {
                case Colors.Red:
                    Console.WriteLine($"color is red");
                    break;
                case Colors.Blue:
                    Console.WriteLine($"color is blue");
                    break;
                case Colors.Green:
                    Console.WriteLine($"color is green");
                    break;
                case Colors.Black:
                    Console.WriteLine($"color is black");
                    break;
                case Colors.Orange:
                case Colors.Yellow:
                    Console.WriteLine($"color is yellow or orange");
                    break;
                default:
                    Console.WriteLine($"color is rainbow");
                    break;
            }

            /*
             * Order of operations
             * 1. Create a string s and initialize it to whatever you like.
             * 2. Write code that does the following using conditional operators:
                * a. If the string length is less than 5 and is odd OR
                * b. If the string length is greater than or equal to 10 and is even
                * c. Print a message
             * 3. Change the string length to make sure your code works properly
             */

            string s = "Frodotheca";

            if ( ( s.Length < 5 && (s.Length % 2 == 1) ) || ( s.Length >= 10 && (s.Length % 2 == 0) ) )
            {
                Console.WriteLine($"this is your string {s}");
            }

            /*
             * Nested conditionals
             * 1. Duplicate the logic above using nested conditionals
             * 2. Do not use any conditional operators when comparing values
             */
            if(s.Length < 5)
            {
                if(s.Length % 2 == 1)
                {
                    Console.WriteLine($"this is your string {s}");
                }
            }
            if(s.Length >= 10)
            {
                if(s.Length % 2 == 0)
                {
                    Console.WriteLine($"this is your string {s}");
                }
            }


        }
        public enum Colors
        {
            Red,
            Blue,
            Yellow,
            Orange,
            Green,
            Black

        }
    }
}
