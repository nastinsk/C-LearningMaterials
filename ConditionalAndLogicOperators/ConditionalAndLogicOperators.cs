using System;

namespace ConditionalAndLogicOperators
{
    class ConditionalAndLogicOperators
    {
        static void Main(string[] args)
        {

            //if/else
            Console.WriteLine("type number x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("type number y");
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("number x is greater that number y");
            }
            else if (x == y)
            {
                Console.WriteLine("number y is equal x");
            }
            else
            {
                Console.WriteLine("number y is greater that number x");
            }


            //We also can skip curly brackets here, looks  like it works with one liners only
            if (x > y)
                Console.WriteLine("number x is greater that number y");
           
            else if (x == y)
                Console.WriteLine("number y is equal x");
    
            else
                Console.WriteLine("number y is greater that number x");
        



            //Switch case

            Console.WriteLine("Do you like cats? (Yes or No)");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "Yes": Console.WriteLine("This is good"); break;
                case "No": Console.WriteLine("You are a bad person"); break;
                default: Console.WriteLine("This is not correct answer"); break;
            }


            //Logical operators
            //And - &&
            //Or - ||
            //Not - !
        }
    }
}
