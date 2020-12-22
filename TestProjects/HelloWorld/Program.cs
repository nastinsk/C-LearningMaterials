using System;

namespace HelloWorld
{

    /// <summary>
    /// Basic console app, that displays "Hello World" to console
    /// </summary>
    
    class Program
    {
   
        static void Main(string[] args)
        {
            var argsStr = string.Join(",", args); //this string will display argument that i prebuild THrough the properties in VS Code
            Console.WriteLine(argsStr); //output "testArg"
            Console.WriteLine("Hello World!");
            string answer = Console.ReadLine();
            Console.WriteLine(answer);
            argsStr = string.Join(",", args);
            Console.WriteLine(argsStr); //output the actual user input and testArg

            //single line comment
            /*
            multi
            line
            comment
            */
        }

    }
}
