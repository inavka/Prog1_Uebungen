using System;
using System.Linq;

namespace _5._1._Feldübung
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] f1 = new int[] {5, 8, 6, 4, 3, 5, 9, 2, 6, 9 };
            int summe = 0;
            Console.Write("f = [");
            for (int n =0; n< f1.Length; n++)
            {
                if (n==f1.Length-1)
                {
                    Console.Write(f1[n]+"]");
                }
                else
                    Console.Write(f1[n] + ", ");
                summe += f1[n];
            }
            double durchschnitt = (double) summe / f1.Length;
            Console.WriteLine($"\nSumme: {summe}");
            Console.WriteLine($"Durchschnitt: {durchschnitt}");

            Console.Write("Neue Zahl: ");
            int zahl = Convert.ToInt32(Console.ReadLine());
            Console.Write("Größer sind: ");
            bool komma = false;
            foreach (int n in f1)
            { 
                if (n>zahl)
                {
                    if (komma)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(n);
                    komma = true;
                }
            }

            int max=f1[0];
            int min=f1[0];

            for (int i = 1; i<f1.Length; i++)
            {
                if (max < f1[i])
                    max = f1[i];
                if (min > f1[i])
                    min = f1[i];
            }
            Console.WriteLine($"\nMaximum: {max}");
            Console.WriteLine($"Minimum: {min}");

            int[] f2 = new int[f1.Length];

            for (int i = 0; i<f1.Length; i++)
            {
                f2[i] = f1[(f1.Length - 1) - i];
            }

            Console.Write("f2 = [");
            komma = false;
            foreach (int a in f2)
            {
                if (komma)
                    Console.Write(", ");
                Console.Write(a);
                komma = true;
            }
            Console.Write("]");
            //System.Linq
            Console.WriteLine($"\nSumme: {f2.Sum()}");
            Console.WriteLine($"Maximum: {f2.Max()}");
            Console.WriteLine($"Minimum: {f2.Min()}");


            Console.ReadKey();
        }
    }
}
