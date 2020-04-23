using System;

namespace _3._5._Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie drei Zahlen ein:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vor Rotation:");
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");

            int cache = b;
            b = a;
            a = c;
            c = cache;

            Console.WriteLine("Nach Rotation:");
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
        }
    }
}
