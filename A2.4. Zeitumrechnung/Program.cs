using System;

namespace A2._4._Zeitumrechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anzahl Sekunden eingeben:");
            int zeit = Convert.ToInt32(Console.ReadLine());
            int minuten = zeit / 60;
            int sekunden = zeit % 60;
            Console.WriteLine($"Das sind: {minuten}:{sekunden} Minuten");
        }
    }
}
