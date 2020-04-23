using System;

namespace _3._2._Teiler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zahl: ");
            int zahl = Convert.ToInt32(Console.ReadLine());

            bool gefunden = false;
            Console.Write("Echte Teiler:");
            for (int i=2; i<zahl; i++)
            {
                if (zahl % i == 0)
                {
                    Console.Write($"{i,4}");
                    gefunden = true;
                }
            }
            if (gefunden == false)
            {
                Console.WriteLine("Primzahl");
            }
        }
    }
}
