using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic functions
             
            PrintString("hi");
            PrintString("you");

            string concatenatedString = ConcatenateStrings("hey", "you", "how are you?");
            Console.WriteLine(concatenatedString);

            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            UpdateArray(myArray, 7, 23);
            UpdateArray(myArray, 23, 23);
            Console.WriteLine(myArray[7]);

            string updatedStr = UpdateString("hi my name is Ana. I have a cat named Frodo mew");
            Console.WriteLine(updatedStr);

            string subStr = GetSubstring("blanket");
            string subStr1 = GetSubstring("blanket", 2, 3);
            string subStr2 = GetSubstring("blanket", 2, 9);
            string subStr3 = GetSubstring("blanket", 10, 2);
            string subStr4 = GetSubstring("blanket", -2, 2);
            string subStr5 = GetSubstring("blanket", 2, -3);
            Console.WriteLine(subStr);
            Console.WriteLine(subStr1);
            Console.WriteLine("answer" + subStr2);
            Console.WriteLine("answer" + subStr3);
            Console.WriteLine("answer" + subStr4);
            Console.WriteLine("answer" + subStr5);


        }

        // 1. Write a function that prints out whatever string you pass into it. Call the function to make sure it works.
        public static void PrintString(string userInput)
        {
            Console.WriteLine(userInput);
        }


        // 2. Write a function that concatenates three strings and returns the result. Call the function to make sure it works.
        public static string ConcatenateStrings(string a, string b, string c)
        {
            return a + b + c;
        }


        /// <summary>Function that takes in an int array, an int index, and an int value. The function should update the array at the specified index with the specified value. If the index is out of range, the function should do nothing. Call the function to make sure it works.</summary>
        /// <param name="intArr"> An integer array </param>
        /// <param name="i"> An integer number of the index </param>
        /// <param name="intVal">An integer value </param>
        public static void UpdateArray(int[] intArr, int i, int intVal)
        {

            try
            {
                intArr[i] = intVal;
            }
            catch (IndexOutOfRangeException e)  
            {
                Console.WriteLine(e.Message);
            }
        }

        // 4. Write a function that takes in a string and returns a new string that contains every other word (starting from the first) in the original. Call the function to make sure it works.
        // a.For example, passing in “to be or not to be” should return “to or to”
        public static string UpdateString(string usersMessage)
        {
            string[] splitString = usersMessage.Split(" ");
            string outputStr = splitString[0] + " ";

            for(int i = 2; i < splitString.Length; i+=2)
            {
                if (i < splitString.Length - 2)
                {
                    outputStr += splitString[i] + " ";

                }
                else
                {
                    outputStr += splitString[i];
                }   
            }

            return outputStr;
        }

        //5. Write a function that takes in a string, an optional int parameter called index, and an optional int parameter called length. The function should return a substring of the original string starting at the specified index, with the specified length. Call the function to make sure it works.
        // *a.If the index or length are out of range, the function should return an empty string.
        // b.If the index is not specified, start at index 0
        // c.If the length is not specified(or is 0), take the rest of the string 

        public static string GetSubstring(string inputStr, int index = 0, int length = 0)
        {
            string subStr = "";               
            
            if (length == 0)
            {
                length = inputStr.Length - index;
            }
        
            if ( length > 0 && index > 0 && ( length <= (inputStr.Length - index) ) )
            {
                Console.WriteLine("length " + length);

                for (var i = 0; i < length; i++)
                {
                    if (index > inputStr.Length - 1)
                    {
                        break;
                    }
                    
                    subStr += inputStr[index];
                   
                    index++;
                }
            }
               
            return subStr;
            

        }
        

        



    }
}
