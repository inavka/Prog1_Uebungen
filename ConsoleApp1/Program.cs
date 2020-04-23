using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Höhe des Körpers (in Meter): ");
            double height = Convert.ToDouble(Console.ReadLine());
            if (height<0)
            {
                Console.WriteLine("Ungültige Höhe");
                return;
            }
            double g = 9.80665;
            double time = Math.Sqrt(2 * (height / g));
            Console.WriteLine($"Fallzeit: {time,7:f6} Sek.");
            Console.ReadKey();  
        }
    }
}
