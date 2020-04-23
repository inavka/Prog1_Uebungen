using System;

namespace _3._6._Ausgabe_der_harmonischen_Reihe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berechnung der harmonischen Reihe");
            Console.Write("Bis zu welchem n? ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for(int i = 1; i<=n; i++)
            {
                sum +=(double) 1 / i;
            }
            Console.WriteLine($"Summe bis 1/{n}: {sum:f7}");
        }
    }
}
