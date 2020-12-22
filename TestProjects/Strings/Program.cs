using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escapes and literals
             * 1. Create a string with escape sequences in it and print it out
             * 2. Create a literal string and print it out
            */
            string escapeStr = "lalala \nkokoko\\gggggh\\";
            Console.WriteLine(escapeStr);
            Console.WriteLine("literal string");

            /*
             * Concatenation
             * 1. Concatenate two strings together and print them out
            */
            string a = "firststring ";
            string b = "secondstring";
            string c = a + b;
            Console.WriteLine(c);

            /*
             * Length
             * 1. Print a string along with its length
            */
            Console.WriteLine("\"" + c + "\"" + " length is " + c.Length);

            /*
             * Indexing
             * 1. Create a string with length > 3 with an odd number of characters.
             * 2. Print the first, middle, and last character, concatenated together.
             * 3. Make sure your code still works when you change the string size to a different odd number.
            */
            string oddStr = "thisisodd";
            Console.WriteLine(oddStr[0] + oddStr[oddStr.Length / 2] + oddStr[oddStr.Length-1]); //prints 321 ????
            Console.WriteLine($"{oddStr[0]} + {oddStr[oddStr.Length / 2]} + {oddStr[oddStr.Length - 1]}");


            /*
             * Changing case
             * 1. Print a string, the same string in all uppercase, and the same string in all lowercase
            */
            string myStr = "This is My string";
            Console.WriteLine($"{myStr}, {myStr.ToUpper()}, {myStr.ToLower()}");

            /*
             * Getting parts of strings
             * 1. Create a string with length > 3.
             * 2. Print the string with both the first and last characters removed.
             * 3. Make sure your code still works if you change the string size.
             * 4. Repeat the above exercise using a different string method.
            */
            oddStr = "thisisoddaga";
            Console.WriteLine(oddStr.Substring(1, oddStr.Length - 2));
            oddStr = oddStr.Remove(0, 1);
            Console.WriteLine(oddStr);
            oddStr = oddStr.Remove(oddStr.Length-2, 1);
            Console.WriteLine(oddStr);

            /*
             * Searching
             * 1. Declare strings x and char y and initialize them to whatever you like.
             * 2. Write an expression that returns the index of the first occurrence of char y in string x
             * 3. Write an expression that returns a bool that represents if y is anywhere in string x
             * 4. Create a literal string that holds a fake path to a file (@”c:\foo\bar.txt”, for example). Write code to get just the file name (no path), without the extension. Write code to get just the drive letter, in uppercase.
            */

            string newStr = "this is new string";
            char newChar = 'e';
            Console.WriteLine(newStr.IndexOf(newChar));
            Console.WriteLine(newStr.Contains(newChar));
            Console.WriteLine($"file name is {@"c:\foo\bar.txt".Substring(7, 3)}, disk name is {@"c:\foo\bar.txt".Substring(0, 1).ToUpper()} ");
            /*
             * Splitting
             * 1. Declare string x and initialize it to whatever you like. Make sure the string has spaces in it.
             * 2. Split the string on space and observe the results
            */
            Console.WriteLine($"{newStr.Split()[0]}, {newStr.Split()[1]}, {newStr.Split()[2]}, {newStr.Split()[3]}");

            Array.ForEach(newStr.Split(), Console.WriteLine); // to print array contents

            /* Formatting
             * 1. Create a const string x that contains formatting tokens
             * 2. Create another string y that uses string.Format to insert values into string x
             * 3. Print string y
             * 4. Create a double d and initialize it to a number with > 2 decimal places.
             * 5. Print the double, but only include 2 decimals when printing
            */

            const string x3 = "hi this is formatted string with {0} and I am {1}";
            string y3 = string.Format(x3, "tokens", "Ana");
            Console.WriteLine(y3);

            double d = 7.877909;
            Console.WriteLine("{0:0.00}", d);

            /* Printing and parsing
             * 1. Create bool a, int b, double c, and char d, and initialize them to whatever you want (other than default values).
             * 2. Convert these types to strings w, x, y, and z.
             * 3. Create bool e, int f, double g, and char h. Use the appropriate Parse() method to initialize these variables from the strings w, x, y, and z.
             */
            bool a1 = true;
            int b1 = 7;
            double c1 = 8.99;
            char d1 = 'u';
            string w = a1.ToString(), x4 = b1.ToString(), y4 = c1.ToString(), z4 = d1.ToString();
            Console.WriteLine($"{w}, {x4}, {y4}, {z4}");
            bool e = Boolean.Parse(w);
            int f = Int32.Parse(x4);
            double g = Double.Parse(y4);
            char h = Char.Parse(z4);
            Console.WriteLine($"{e}, {f}, {g}, {h}");
        }
        

    }
}
