using System;

namespace ReadLineAndArithmetic
{
    class ReadLineAndArithmetic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi What is your name?");

            string userName = Console.ReadLine();

            //String interpolation
            Console.WriteLine($"Hi {userName}");


            //Arithmetic Operators

            int x = 6;
            int y = 9;
            int result = 0;
            result = x + y;
            Console.WriteLine("Add x + y  as contatenation, result is:" + x + y); //result 69
            Console.WriteLine("Correct result: " + result); //result 15

            //C# has % a remainder operator

            int a, b;
            float divResult;
            Console.WriteLine("Enter an integer number"); //if user will enter float it will throw an error
            a = int.Parse(Console.ReadLine()); //I entered 7
            Console.WriteLine("Enter a second integer number");
            b = int.Parse(Console.ReadLine()); //I entered 2
            divResult = a / b;
            Console.WriteLine($"{a} / {b} = {divResult}"); //here result will be 2
            divResult = (float)a / (float)b;
            Console.WriteLine($"{a} / {b} = {divResult}"); //here result will be 3.5

        }
    }
}
