using System;

namespace _7._3._SeparatorCounter__Funktion_mit_Out_Parametern_
{
    class Program
    {
        static void SeparatorCounter(string s, out int punkt, out int komma, out int semi)
        {
            punkt = 0;
            komma = 0;
            semi = 0;
            foreach(char c in s)
            {
                switch (c)
                {
                    case '.':
                        punkt++;
                        break;
                    case ',':
                        komma++;
                        break;
                    case ';':
                        semi++;
                        break;
                }
}
        }
        static void Main(string[] args)
        {
            int punkt, komma, semi;
            string test = "A, B, C; D; E; F. G; H; I";
            SeparatorCounter(test, out punkt, out komma, out semi);
            Console.WriteLine("Punkte: " + punkt);
            Console.WriteLine("Kommas: " + komma);
            Console.WriteLine("Semikolons: " + semi);
        }
    }
}
