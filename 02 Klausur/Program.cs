using System;

namespace _02_Klausur
{
    class Program
    {
        enum MedienTyp { Foto=0, DVD, mp4, Audio}
        class Medium
        {
            string name;
            int serNr = 0;
            static int nextNr=1;
            MedienTyp typ;

            public Medium(string Name, MedienTyp Typ= MedienTyp.Foto)
            {
                name = Name;
                typ = Typ;
                serNr = nextNr;
                nextNr++;
            }
            public string Name
            {
                get
                {
                    return name;
                }
            }
            public int Anzahl
            {
                get
                {
                    return (nextNr - 1);
                }
            }
            public static int[] Statistik(params Medium[] f)
            {
                int[] ergebnis = new int[4];
                for (int i = 0; i<f.Length; i++)
                {
                    if (f[i].typ == MedienTyp.Foto)
                        ergebnis[0]++;
                    if (f[i].typ == MedienTyp.DVD)
                        ergebnis[1]++;
                    if (f[i].typ == MedienTyp.mp4)
                        ergebnis[2]++;
                    if (f[i].typ == MedienTyp.Audio)
                        ergebnis[3]++;
                }
                return ergebnis;
            }
            public static Medium Suche(Medium[] f, string text)
            {
                for (int i = 0; i<f.Length; i++)
                {
                    if (f[i].name.Contains(text))
                        return f[i];
                }
                return null;
            }
        }
        static void Main(string[] args)
        {
            Medium m1 = new Medium("test", MedienTyp.DVD);
            Medium m2 = new Medium("test2");
            int[] statistik = Medium.Statistik(m1, m2);

            int x, y;
            for (x = 1; x <= 3; x++)
            {
                for (y = 1; y <= 3; y++)
                {
                    if (y <= x)
                        Console.Write("{0} ", x * y);
                }
                Console.WriteLine();
            }
            int a = 0;
            int b = 5;
            if (a > b && !(b == 0))
            {
                Console.WriteLine("A");
            }
            if (a / b > 5 && b != 0)
            {
                Console.WriteLine("B");
            }
            else if (a != 0 || b != 0)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("D");
            }

        }
    }
}
