using System;

namespace TryParseAndConstants
{
    class TryParseAndConstants
    {
        static void Main(string[] args)
        {

        //How to figure out if input is integer?
        Console.WriteLine("type integer");
        
        
      
        bool isNumerical = int.TryParse(Console.ReadLine(), out int myIntBool);
        Console.WriteLine($"Your input is {isNumerical}");//Your input is 0

        int input_num;
        int.TryParse(Console.ReadLine(),out input_num)67 ,m,,
        Console.WriteLine($"Your input is {input_num}"); //Your input is 0

            //The difference between Parse and TryParse
            //it tkes 2 parameters  - something that need to be parsed and variable name where it will be parsing to
            //if TryParse find that you enterd invlid value it will return 0 in our myInt variable
        }
    }
}
