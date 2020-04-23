using System;

namespace _7._1._Histogramm_zu_Buchstaben_Häufigkeiten
{
    class Program
    {
        static int BuchstabenIndex(char b)
        {
            if (b == 'ß')
                b = 's';
            b = Char.ToUpper(b);
            if (b == 'Ö')
                b = 'O';
            if(b== 'Ä')
                b = 'A';
            if (b == 'Ü')
                b = 'U';
            int index = b - 'A';
            if (index < 0 || index>25)
                return -1;
            return index;
        }

        static void Statistik(int[] f, string text)
        {
            int index;
            foreach (char c in text)
            { 
                index = BuchstabenIndex(c);
                if (index != -1)
                    f[index]++;
            }
        }
        static void Main(string[] args)
        {
            string gedicht =
                @"Joachim Ringelnatz: Genau besehn
                  Wenn man das zierlichste Näschen
                  Von seiner liebsten Braut
                  Durch ein Vergrößerungsgläschen
                  Näher beschaut,
                  Dann zeigen sich haarige Berge,
                  Daß einem graut.";

            string satz = "Der böse Aal beißt";

            string test = "Aaboösßz ?.";
            int[] statistik = new int[26];
           
            foreach (char c in test)
            {
                Console.WriteLine($"BuchstabenIndex('{c}') = " + BuchstabenIndex(c));
            }

            Statistik(statistik, gedicht);
           
            for(int i =0; i<statistik.Length; i++)
            {
                char c = (char)(i + 'a');
                int anzahl = statistik[i];
                Console.Write($"{c}, {anzahl,2}:");
                for(int j = 0; j<=anzahl; j++)
                    Console.Write('\u2584');
                Console.WriteLine();
            }
        }
    }
}
