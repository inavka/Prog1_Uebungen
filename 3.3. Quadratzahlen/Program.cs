using System;

namespace _3._3._Quadratzahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zahl: ");
            int zahl = Convert.ToInt32(Console.ReadLine());

            bool komma = false;
            int n = 1;
            int q;
            Console.WriteLine();
            Console.Write($"Quadratzahlen bis max. {zahl}: ");
            while (n < Math.Sqrt(zahl))
            {
                q = n * n;
                if (komma)
                    Console.Write($", {q}");
                else
                {
                    Console.Write(q);
                    komma = true;
                }
                n++;
            }
        }
    }
}
