using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Create an enum inside the HelloWorld namespace, but outside of the Program class
             * 2. Call the enum whatever you like, populate it with whatever names and values you like
             * 3. Declare a variable and assign it to one of the enum values.
             * 4. Using the variable, print both the enum name AND the enum valu
             */
            var myMood = Mood.Sleepy; 
            var myIntMood = (int)myMood; //if myInt is not in the enum list program will exited with code
            var textMood = (Mood)myIntMood;

            Console.WriteLine(myIntMood); //will return 100
            Console.WriteLine(textMood); //will return Sleepy


            //Correct way to deal with the situation when myInt not exists in enum Mood
            /*
            if(Enum.IsDefined(typeof(Mood), myInt))
            {
                var myMood = (Mood)myInt;
            }
            else
            {
                Handle exception
            }
            */

            Week myDay = Week.Wednesday;
            int myIntDay = (int)myDay;
            var textDay = (Week)myIntDay;

            Console.WriteLine(myIntDay); //will return 2
            Console.WriteLine(textDay); //will return Wednesday

        }
    }
    enum Mood
    {
        Hungry = 0,
        Happy = 1,
        Sleepy = 100,
        Greedy
    }

    enum Week
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

}
