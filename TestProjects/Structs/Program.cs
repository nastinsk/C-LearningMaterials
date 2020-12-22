using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Structs
             * 1. Create a struct inside the HelloWorld namespace, but outside of the Program class
             * 2. Call the struct whatever you like and add some members to it
             * 3. Declare a variable x and instantiate the struct
             * 4. Declare a variable y and instantiate the struct
             * 5. Set every member in x to the values of every member in y
             * 6. Print the members of x
             */

            Pet x = new Pet("dog", "Sam", 6, "brown");
            x.SayHi();
            Pet y = new Pet("cat", "Frodo", 5, "black and white");
            x.type = y.type;
            x.name = y.name;
            x.color = y.color;
            x.age = y.age;
            x.SayHi();
            y.SayHi();


            
        }
    }

    struct Pet
    {
        public string type;
        public string name;
        public int age;
        public string color;

        public Pet(string type, string name, int age, string color){
            this.type = type;
            this.name = name;
            this.age = age;
            this.color = color;
        }
        public void SayHi()
        {
            Console.WriteLine($"hi this is {this.color} {this.type} that named {this.name}, my age is {this.age}");
        }


    }
}
