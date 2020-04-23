using System;

namespace A2._1.__Einfache_Verzweigung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie Ihren Namen an: ");
            string name = Console.ReadLine();
            Console.Write("(H)err oder (F)rau: ");
            char sex = Convert.ToChar(Console.ReadLine());

            if (sex == 'H' || sex =='h')
            {
                Console.WriteLine($"\nGuten Tag, Herr {name}!");
            } else if (sex == 'F' || sex == 'f')
            {
                Console.WriteLine($"Guten Tag, Frau {name}!");
            } else
            {
                Console.WriteLine("Falsche Eingabe");
            }
        }
    }
}
