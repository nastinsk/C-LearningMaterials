using System;
using System.Collections.Generic;

namespace ListsAndLoops
{
    class ListsAndLoops
    {
        static void Main(string[] args)
        {
            //While loop
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            //The while loop tests the condition before executing the code following the while. The do ... while loop executes the code first, and then checks the condition. Which means that with “while” loop code can be not executed with “do … while” it will be executed at least once

            int counter2 = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter2}");
                counter2++;
            } while (counter2 < 10);

            //For Loop 
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }
            /* The first part is the for initializer: int counter = 0; declares that counter is the loop variable, and sets its initial value to 0. The middle part is the for condition: counter < 10 declares that this for loop continues to execute as long as the value of counter is less than 10. The final part is the for iterator: counter++ specifies how to modify the loop variable after executing the block following the for statement.Here, it specifies that counter should be incremented by 1 each time the block executes. */


            //Foreach and Lists
            // foreach loop iterates over contents of iterable object

            var names = new List<string> { "Derek", "Ana", "Frodo" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            //Add to list to the end
            names.Add("Maria");
            //Remove the elemnt from list
            names.Remove("Ana");

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}

