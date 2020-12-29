using System;

namespace ReadTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Reading text files
             * 1. Create a text file anywhere on your computer and fill it with a few lines of text
             * 2. Read the file using any function in the System.IO.File class and print the file contents
             * 3. Repeat step 2 using the System.IO.StreamReader class
                * a. Make sure to use a “using” block
             */
            string filePath = @"/Users/Ana/source/repos/CSharpLearning/FilesIOExercises/ReadTextFiles/textFile.txt";
            string[] lines = System.IO.File.ReadAllLines(filePath);
            Array.ForEach(lines, Console.WriteLine);

            using (var reader = new System.IO.StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
    }
}
