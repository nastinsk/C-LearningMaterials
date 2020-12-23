using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * While
             * 1. Create an infinite while loop and run your program to see what happens
             * 2. Create a string s and initialize it to “0123456789”
             * 3. Use a while loop to print every odd digit in the string, all on the same line.
             */
            //while (true)
            //{
            //    Console.WriteLine("we are in infinite while loop");
            //}
            string s = "0123456789";
            int i = 0;
            while (i < s.Length)
            {
                if ((int)s[i] % 2 == 1)
                {
                    Console.Write(s[i]);
                }
                i++;
            }
            /*
             * Do While
             * 1. Duplicate the above logic using a Do While loop
             */
            Console.Write("\n");
            i = 0;

            do
            {
                if ((int)s[i] % 2 == 1)
                {
                    Console.Write(s[i]);
                }
                i++;
            }
            while (i < s.Length);


            /*
             * For
             * 1. Duplicate the above logic using a for loop
             */

            //Infinite for loop - Example
            //for (; ; )
            //{
            //    Console.WriteLine("we are in infinite for loop");
            //}

            //second infinite for loop - Example
            //for (i = 1; i > 0; i++)
            //{
            //    Console.WriteLine("we are in infinite for loop");

            //}

            Console.Write("\n");
            for (i = 0; i < s.Length; i++)
            {
                if ((int)s[i] % 2 == 1)
                {
                    Console.Write(s[i]);
                }
            }

            /*
             * Foreach
             * 1. Duplicate the above logic using a foreach loop
             */
            Console.Write("\n");
            foreach (char digit in s)
            {
                if ((int)digit % 2 == 1)
                {
                    Console.Write(digit);
                }
            }

            /*
             * Nested loops
             * 1. Imagine you have a hat with 5 different numbers in it. You take out numbers, one at a time, without putting them back.
             * 2. Write code that prints out every possible combination of numbers you can get, in all the different orders you can get them. Use any type of loops you want
             */
            string hat = "12345";
            Console.Write("\n");
            for( i = 0; i < hat.Length; i++)
            {
                for(var j = 0; j < hat.Length; j++)
                {
                    for(var z = 0; z < hat.Length; z++)
                    {
                        for (var a = 0; a < hat.Length; a++)
                        {
                            for (var b = 0; b < hat.Length; b++)
                            {
                                if (i != j && i != z && i != a && i != b && j != z && j != a && j != b && z != a && z != b && a != b)
                                {
                                    Console.WriteLine($"{hat[i]}{hat[j]}{hat[z]}{hat[a]}{hat[b]}");
                                }
                            }
                        }
                    }
                }
            }



            /*
             * Loop flow control
             * 1. Declare a string s and initialize it to whatever you want.
                * a. Make sure the first character in your string is repeated somewhere else in the string
             * 2. Write a loop that searches through the string and looks for another occurrence of the first character found.
             * 3. If the character found doesn’t match the first one, the loop should immediately go to the next letter
             * 4. If the character found matches, print the index of the match, and immediately exit the loop.
             */
            s = "catcatdog";
            
            for (i = 1; i < s.Length; i++)
            {
                //code if we want to use "continue statement" for some reason
                //if(s[i] != s[0])
                //{                   
                //    continue;
                //}
                if(s[i] == s[0])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
