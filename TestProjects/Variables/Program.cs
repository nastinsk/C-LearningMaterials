using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Variables are set to default value when they declared
            Default value for bool is false,
            for int - 0,
            for double / float - 0.0, 
            for char is the null character(‘\0’),
            for string is null
            */


            /*
            * Min / Max values
            * 1. Declare an int and initialize it to the max value
            * 2. Increment the int by one
            * 3. Observe what happens 
            */
            
            int maxInt = int.MaxValue;


            Console.WriteLine(maxInt); //output 2147483647
            maxInt++;
            Console.WriteLine(maxInt); //output -2147483648

            int x = 4;
            int y = 5;
            double z = 4 / 5;
            Console.WriteLine(z); //output iz 0 because we have 2 integers here

            string empty = "";
            Console.WriteLine(string.IsNullOrEmpty(empty));

            /*
             * Variables
             * 1. Declare a bool, an int, a double, a char, and a string
             * 2. Initialize all variables with values
             * 3. Print the values to the consol
             */
            bool testBool = true;
            int testInt = 9;
            double testDouble = 0.878;
            char testChar = 'j'; //char should use single quotes onle, double quotes for strings
            string testString = "hi";

            Console.WriteLine("here we have \ntestBool\t testInt\t testDouble\t testChar\t testString");
            Console.WriteLine($"{testBool}\t\t {testInt}\t\t {testDouble}\t\t {testChar}\t\t {testString}");


            /* Implicit types
             * 1. Declare a bool, an int, a double, a char, and a string all using “var” 
             */

            var varBool = false;
            var varInt = 9;
            var varDouble = 0.89;
            var varChar = '\x007A'; //code for letter 'z'
            var varString = "jkl";

            Console.WriteLine("here we have \nvarBool\t\t varInt\t\t varDouble\t varChar\t varString");
            Console.WriteLine($"{varBool}\t\t {varInt}\t\t {varDouble}\t\t {varChar}\t\t {varString}");


        }
    }
}
