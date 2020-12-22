using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6, y = 789, z = -3;
            double a = 8.890, b = -0.7866, c = - 5.77;
            double doubleX = x, doubleY = y, doubleZ = z;
            int intA = (int)a, intB = (int)b, intC = (int)c;
            Console.WriteLine($"doubleX = {doubleX}, doubleY = {doubleY}, doubleZ = {doubleZ} \nintA = {intA}, intB = {intB}, intC = {intC}"); //output doubleX = 6, doubleY = 789, doubleZ = -3         intA = 8, intB = 0, intC = -5

        }
    }
}
