using System;

namespace A2._2._Beitragsrechnung_für_einen_Verein
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beitragsrechnung für einen Verein");
            Console.WriteLine("=================================");
            Console.Write("Geben Sie Ihr Alter ein: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (6 >= age && age > 0)
            {
                Console.WriteLine("Kein Beitrag nötig");
            }
            else if (age >= 7 && age <= 17)
            {
                Console.WriteLine("Ihr Beitrag ist 30 Euro.");
            }
            else if (age >= 18 && age <= 65)
            {
                Console.Write("Sind Sie erwerbslos (j/n): ");
                char reply = Convert.ToChar(Console.ReadLine());
                if (reply == 'j')
                {
                    Console.WriteLine("Ihr Beitrag ist 40 Euro.");
                }
                else
                {
                    Console.WriteLine("Ihr Beitrag ist 80 Euro.");
                }
            }
            else if (age > 65)
            {
                Console.WriteLine("Ihr Beitrag ist 50 Euro. ");
            }
            else
            {
                Console.WriteLine("Falsche Eingabe");
            }
        }
    }
}
