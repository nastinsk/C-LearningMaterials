using System;

namespace CommandLineArgs
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Command-line arguments
             * 1. Create an enum called Direction with the values: Up, Down, Left, and Right
             * 2. Create a program that expects three arguments – a Direction, a bool, and an int.
                * a. If the program is called with no arguments OR called with one argument of “/?”, print a help message explaining what arguments are expected with an example of a valid command line.
                * b. If either of the first two arguments are missing, print an error message. The third argument is optional
             * 3. Store the arguments in variables of the appropriate type
                * a. If any value can’t be stored correctly, print an error message
                * 4. Print the variables stored in step 3. Make sure to include the int if it was specified*/


            //If the program is called with no arguments OR called with one argument of “/?”, print a help message explaining what arguments are expected with an example of a valid command line
            if (args.Length == 0 || args[0] == "/?" )
            {
                Console.WriteLine("Please insert correct arguments. Program expects (Directions, bool, int), example (Down, true, 8)");
                string userInput = Console.ReadLine();
                args = userInput.Split(" ");

                Main(args);
            }
            //If either of the first two arguments are missing, print an error message. The third argument is optional
            else if (args.Length < 2) 
            {
                Console.WriteLine("Argument error");
                Environment.Exit(0);
            }

            else 
            {
                //Check if first Argument in Directions enum
                if (Enum.TryParse(args[0], true, out Directions firstArg))
                {
                    if (Enum.IsDefined(typeof(Directions), args[0]))
                    {
                        firstArg = (Directions)Enum.Parse(typeof(Directions), args[0], true);
                    }
                }
               
                else
                {
                    Console.WriteLine("the first argument is not part of the Directions enum");
                    Environment.Exit(0);
                }
               
                //check if secon argument is boolean
                if (Boolean.TryParse(args[1], out bool secondArg) == false)
                {
                    Console.WriteLine("the second argument is not boolean");
                    Environment.Exit(0);
                }

               
                if (args.Length == 3)
                {
                    //check if third argument is integer
                    if (Int32.TryParse(args[2], out int thirdArg) == false)
                    {
                        Console.WriteLine("the third argument is not integer");
                        Environment.Exit(0);
                    }
                    Console.WriteLine($"this is your arguments {firstArg}, {secondArg}, {thirdArg}");
                    Environment.Exit(0);
                }
                //if we have only 2 arguments print only 2 of them
                else
                {
                    Console.WriteLine($"this is your arguments {firstArg}, {secondArg}");
                }
            }
        }


        //public static void myMethod (Directions userDirection, bool userBool, int userInt)
        //{
        //    if (Program.Main.args.Length == 0 || userDirection == "/?")
        //    {
        //        Console.WriteLine("Please insert correct arguments. Program expects (Directions, bool, int), example (Down, true, 8)");
        //    }
        //}
    }

   
    enum Directions
    {
        Up,
        Down,
        Left,
        Right
    }
}
