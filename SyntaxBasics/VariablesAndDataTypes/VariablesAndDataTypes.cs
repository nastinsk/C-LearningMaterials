using System;

namespace Variables
{
    class VariablesAndDataTypes
    {
        static void Main(string[] args)
        {
            int x = 1;
            Console.WriteLine("Number x is " + x);
            x = 5;
            Console.WriteLine("Number x is " + x);

            double double_num = 0.0d;
            float float_num = 0.0f;
            decimal decimal_num = 0.000m;

            double_num = 9.8d;

            Console.WriteLine("Number double_num is " + double_num); //Result "Number double_num is 9.8"
            Console.WriteLine("Number float_num is " + float_num); // Result "Number float_num is 0"
            Console.WriteLine("Number  decimal_num is " + decimal_num); //Result "Number decimal_num is 0.000"

            char letter_z = 'z';
            string HisName = "John";
            string HerName = "Lida";

            string firstStr, secondStr, thirdStr;

            firstStr = "one";
            secondStr = "two";
            thirdStr = "3";
            Console.WriteLine("text result:" + letter_z + HerName + HisName + firstStr + secondStr + thirdStr);

            bool IsWorking;
            IsWorking = false;
            Console.WriteLine(IsWorking);
            bool Good = true;

            //Type conversion

            int serialN = 100;
            string accountN = "";
            float anyN = 3.5f;

            //Reaasign int to str
            accountN = serialN.ToString();
            Console.WriteLine(accountN); //Result is 100

            //reassign int to float
            anyN = serialN; //Float can handle reassigning to int but not opposite
            Console.WriteLine(anyN); //Result is 100

            //Reassign float to int
            int serialZ = 0;
            anyN = 4.6f;
            serialZ = Convert.ToInt32(anyN);
            Console.WriteLine(serialZ); //Result is "5", because "Convert" rounds it

            //Reassign float to int - second solution:
            int serialA = 0;
            float newAnyN = 4.7f;

            serialA = (int)newAnyN;
            Console.WriteLine(serialA); //Result is "4" because it doesn't round


            var dynamikVar = "kotik";
            Console.WriteLine(dynamikVar); //C# defines type of variable by itself

            decimal num = 2.5m;
            double num2 = 2.50; //double doesn't explicitly need the letter "d" for assignment, but float and decimal do
            float num3 = 2.5f;

            int t, y = 0, z; //doesn't thorow error
            //Console.WriteLine(t);
            Console.WriteLine(y); //result 0


            //Numbers that can be stored in int
            int maxInt, minInt;
            maxInt = int.MaxValue;
            Console.WriteLine(maxInt); //Result 2147483647
            minInt = int.MinValue;
            Console.WriteLine(minInt);//Result -2147483648

            uint maxUint = uint.MaxValue;
            Console.WriteLine(maxUint);//Result 4294967295, the min value is 0. uint can't be negative

            Console.WriteLine(typeof(string).IsPrimitive); //Function to find out is data type is primitive or not, string is not primitive


            //Another wa of concatenation:
            float f_no = 0.0f;
            double d_no = 0.0d;
            decimal m_no = 0.0m;

            f_no = 1 / 3f;
            d_no = 1 / 3d;
            m_no = 1 / 3m;


            Console.WriteLine("Float N is {0}, double N is {1}, decimal N is {2}", f_no, d_no, m_no); //Result is "Float N is 0.33333334, double N is 0.3333333333333333, decimal N is 0.3333333333333333333333333333"



            


        }
    }
}
