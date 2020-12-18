using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 100; 
            var myMood = (Mood)myInt; //if myInt is not in the enum list program will exited with code
           Console.WriteLine(myMood); //will return Sleepy
        }
    }
    enum Mood
    {
        Hungry = 0,
        Happy = 1,
        Sleepy = 100
    }

}
