using System;

namespace TryParseAndConstants
{
    class TryParseAndConstants
    {
        static void Main(string[] args)
        {

        //The difference between Parse and TryParse
        //it tkes 2 parameters  - something that need to be parsed and variable name where it will be parsing to
        //if TryParse find that you enterd invlid value it will return 0 in our myInt variable

        //How to figure out if input is integer?
        Console.WriteLine("type integer");
        
        
      
        bool isNumerical = int.TryParse(Console.ReadLine(), out int myIntBool);
        Console.WriteLine($"Is your input an integer?: {isNumerical}");//wil answer yes or no
        Console.WriteLine($"Your input is {myIntBool}"); //will display input if its int or "0" if not
           if (myIntBool == 0)
            {
                Console.WriteLine("myIntBool == 0");
            }

        //the same result but we declare varible outside of the TryParse
        int input_num;
        int.TryParse(Console.ReadLine(), out input_num);
        Console.WriteLine($"Your input is {input_num}"); //Your input is 0


            //Constant variables - variales that can't be changed
            const int myConst = 9;
            //myConst = 8; - will throw an error

        }
    }
}
