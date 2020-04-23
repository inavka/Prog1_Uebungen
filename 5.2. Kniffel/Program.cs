using System;

namespace _5._2._Kniffel
{
    class Program
    {
       
        public static bool Kniffel(int[] f)
        {
            for(int i=f.Length-1; i>0;i--)
            {
                if (f[i] != f[i - 1])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] f1 = { 3, 3, 3, 3 };
            Console.WriteLine($"f1 - {Kniffel(f1)}");
            int[] f2 = { 4, 4, 5, 2 };
            Console.WriteLine($"f2 - {Kniffel(f2 )}");

            Console.Write("Würfelanzahl: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] wuerfelFeld = new int[n];

            Random rnd = new Random();
            int anzahl = 0;
            do
            { 
                anzahl++;
                Console.WriteLine();
                for (int i = 0; i < wuerfelFeld.Length; i++)
                {
                    wuerfelFeld[i] = rnd.Next(1,7);

                    if (i == 0)
                    {
                        Console.Write($"{anzahl}. Wurf: {wuerfelFeld[i]}");
                    }
                    else
                    {
                        Console.Write($", {wuerfelFeld[i]}");
                    } 
                }
            } while (!Kniffel(wuerfelFeld));
            Console.WriteLine($"\nKniffel nach dem {anzahl} Wurf! ");
        }
    }
}
