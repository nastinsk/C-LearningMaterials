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

            //to search list element by index
            Console.WriteLine($"Name at index 0 is {names[0]}");

            //to get the amount of elements (length) of the list
            Console.WriteLine($"The list has {names.Count} elements in it");


            // The IndexOf method searches for an item and returns the index of the item. If the item isn't in the list, IndexOf returns -1.
            var indexName = names.IndexOf("Felipe");
            Console.WriteLine($"name Filipe is not in the list this why IndexOf returns {indexName}");
            indexName = names.IndexOf("Derek");
            Console.WriteLine($"name Derek is in the list this why IndexOf returns {indexName}");


            // The Sort method sorts all the items in the list in their normal order (alphabetically for strings).
            names.Add("Maria");
            names.Sort();

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}

