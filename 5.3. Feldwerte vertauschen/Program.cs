using System;

namespace _5._3._Feldwerte_vertauschen
{
    class Program
    {
        public static void Tauschen(int[] f)
        {
            int cache;
            for (int i = 0, j = f.Length - 1; i < f.Length/2; i++, j--)
            {
                cache = f[i];
                f[i] = f[j];
                f[j] = cache;
            }
        }
        static void Main(string[] args)
        {
            int[] f1 = { 1, 6, 9, 8, 3, 6, 8, 9 };
            Console.Write("Feld vorher: ");
            foreach (int a in f1)
            {
                Console.Write(" "+a);
            }
            Console.WriteLine();
            Tauschen(f1);
            Console.Write("Feld nachher: ");
            foreach (int a in f1)
            {
                Console.Write(" " + a);
            }
            Console.WriteLine();
            Array.Reverse(f1);
            Console.Write("Feld nachher: ");
            foreach (int a in f1)
            {
                Console.Write(" " + a);
            }
           
        }
    }
}
