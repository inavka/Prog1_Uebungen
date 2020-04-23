using System;

namespace _4._3._Ziffern_Test
{
    class Program
    {
        static int ZifferAnzahl(int n, int z)
        {
            int rest;
            int zaehler = 0;
            while (n != 0)
            {
                rest = n % 10;
                if (rest == z)
                    zaehler++;
                n /= 10;
            }
            return zaehler;
        }
        static void Main(string[] args)
        {
            int zahl;
            do
            {
                Console.Write("Zahl eingeben: ");
                zahl = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ziffer eingeben: ");
                int ziffer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Die Zahl {zahl} enthält {ZifferAnzahl(zahl, ziffer)}x die Ziffer {ziffer}. ");
                Console.WriteLine();
            } while (zahl != 0);
            Console.WriteLine("Ende.");
        }
    }
}
