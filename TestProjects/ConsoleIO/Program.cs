using System;

namespace ConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Console I/O
             * 1. Create a program that prompts the user for their first name, then middle name, then last name, all on different lines.
             * 2. Print the first, middle, and last name all on the same line
             * 3. Print “Press any key to exit…” and wait for the user to press a key to exit.
             */
            Console.WriteLine("Hi please type your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Hi please type your middle name");
            string middleName = Console.ReadLine();
            Console.WriteLine("Hi please type your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Hi {firstName} {middleName} {lastName}");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            //to exit application
            Environment.Exit(0);

        }
    }
}
