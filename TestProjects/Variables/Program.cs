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

            int testInt = int.MaxValue;


            Console.WriteLine(testInt);
            testInt++;
            Console.WriteLine(testInt);

            int x = 4;
            int y = 5;
            double z = 4 / 5;
            Console.WriteLine(z);

            string empty = "";
            Console.WriteLine(string.IsNullOrEmpty(empty));

        }
    }
}
