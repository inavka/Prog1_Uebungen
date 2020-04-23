using System;

namespace _3._4._Temperatur_Umrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" °C | °F ");
            Console.WriteLine("----+----");
            double f;
            for(double c = 0.0; c<=100.0; c+=5)
            {
                f = 9.0 / 5.0 * c + 32;
                Console.WriteLine($"{c,4:f1} | {f,4:f1}");
            }
        }
    }
}
