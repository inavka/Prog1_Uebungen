using System;

namespace _11._1._Klasse_Auto
{
    class Program
    {
        enum Autotyp 
        {
            Kombi, 
            Kompakt, 
            Cabrio, 
            SUV, 
            Unbekannt
        }
        class Auto
        {
            int nummer;
            static int nextNr = 1;
            string hersteller;
            string modell;
            double ps;
            Autotyp typ;
            public Auto(string Hersteller, string Modell, double PS, Autotyp Typ=Autotyp.Unbekannt)
            {
                nummer = nextNr;
                nextNr++;
                hersteller = Hersteller;
                modell = Modell;
                if (PS <= 0)
                    throw new ArgumentOutOfRangeException();
                ps = PS;
                typ = Typ;
            }
            public Autotyp Typ
            {
                get
                {
                    return typ;
                }
                set
                {
                    typ = value;
                }
            }
            public string Modell
            {
                get
                {
                    return hersteller + modell;
                }
            }
            public override string ToString()
            {
                return $"Nr.{nummer}: {hersteller} {modell}, {typ}, {ps} PS";
            }
            public static Auto Staerkstes(params Auto[]f)
            {
                Auto strk = f[0];
                for(int i = 1; i<f.Length; i++)
                {
                    if (f[i].ps > strk.ps)
                        strk = f[i];
                }
                return strk;
            }
        }
        static void Main(string[] args)
        {
            Auto[] f = new Auto[4];
            f[0] = new Auto("VW", "Golf", 200, Autotyp.Kombi);
            f[1] = new Auto("Audi", "A4", 150);
            f[2] = new Auto("BMW", "X5", 162);
            f[3] = new Auto("Audi", "A4", 210, Autotyp.Cabrio);
            Console.WriteLine(f[0]);
            Console.WriteLine(f[1]);
            Console.WriteLine(f[2]);
            Console.WriteLine(f[3]);
            Console.WriteLine($"Stärkstes Auto ist: {Auto.Staerkstes(f)}");
        }
    }
}
