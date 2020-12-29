using System;

namespace WriteTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Writing text files
             * 1. Write to a text file using any function in the System.IO.File class. Open the file in notepad to verify the results.
             * 2. Repeat step 1 but append to the file instead of overwriting it. Open the file in notepad to verify the results.
             * 3. Repeat step 2 using the System.IO.StreamWriter class. Open the file in notepad to verify the results.
                    * a. Make sure to use a “using” block
             */
            /*
             * The Hobbit was first published in September 1937. Its 1951 second edition (fifth 
            impression) contains a significantly revised portion of Chapter V, “Riddles in the 
            Dark,” which brings the story of The Hobbit more in line with its sequel, The 
            Lord of the Rings, then in progress. Tolkien made some further revisions to the 
            American edition published by Ballantine Books in February 1966, and to the 
            British third edition (sixteenth impression) published by George Allen & Unwin 
            later that same year. 
         */
            string filePath = @"/Users/Ana/source/repos/CSharpLearning/FilesIOExercises/WriteTextFiles/textFile1.txt";
            string s = @"The Hobbit was first published in September 1937. Its 1951 second edition (fifth 
            impression) contains a significantly revised portion of Chapter V, “Riddles in the
            Dark,” which brings the story of The Hobbit more in line with its sequel, The
            Lord of the Rings, then in progress.Tolkien made some further revisions to the
           American edition published by Ballantine Books in February 1966, and to the
           British third edition(sixteenth impression) published by George Allen &Unwin
            later that same year.";
            System.IO.File.WriteAllText(filePath, s);
            string filePath2 = @"/Users/Ana/source/repos/CSharpLearning/FilesIOExercises/ReadTextFiles/textFile.txt";

            //store text lines from second file in array
            string[] firstFileText = System.IO.File.ReadAllLines(filePath2);
            //add all lines from array to the end of the file
            System.IO.File.AppendAllLines(filePath, firstFileText);

            string str = "Hellow world and cats!".ToUpper();
            bool append = true;

            using (var writer = new System.IO.StreamWriter(filePath, append))
            {
                writer.WriteLine(str);
            }



        }
    }
}
