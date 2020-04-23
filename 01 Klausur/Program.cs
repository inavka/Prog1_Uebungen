using System;

namespace _01_Klausur
{
    class Program
    {
        enum Status {Neu, Offen, Bearbeiteten, Geschlossen }

        class Bug
        {
            int id;
            static int nextId = 1;
            string bez;
            Status status;

            public Bug (string Bez, Status stat= Status.Neu)
            {
                if (Bez.Length == 0)
                    throw new ArgumentException(" ");
                id = nextId;
                nextId++;
                bez = Bez;
                status = stat;
            }

            public bool Gefixt
            {
                get
                {
                    if (status == Status.Bearbeiteten || status == Status.Geschlossen)
                    {
                        return true;
                    }
                    return false;
                }
            }
            public bool IstDuplikat (Bug b)
            {
                if (b.bez == this.bez)
                    return true;
                return false;
            }
            public static void DuplikateAusgeben(params Bug[] bugs)
            {
                for (int i = 0; i<bugs.Length; i++)
                {
                    for (int j = 0; j<bugs.Length; j++)
                    {
                        if (bugs[i].bez==bugs[j].bez && bugs[i].id!=bugs[j].id)
                        {
                            Console.WriteLine($"{bugs[i].id} = {bugs[j].id}");
                        }
                    }
                }
            }
        }
        static void Minima (int[] f)
        {
            for (int i = 1; i<f.Length-1; i++)
            {
                if (f[i] < f[i-1] && f[i]<f[i+1])
                {
                    Console.WriteLine(f[i]);
                }
            }
        }

        static string Addiere (string z1, string z2)
        {
            int uebertrag = 0;
            string erg = "";
            char sum= '0';
            for (int i = z1.Length - 1; i >= 0; i--)
            {
                sum = (char)(z1[i] - '0' + z2[i] + uebertrag);

                if (sum > '9')
                {
                    uebertrag++;
                }
                erg = sum + erg;
            }
            return erg;
        }

        static void Add(out int a, ref int b)
        {
            a = 3 * b;
            b -= a;
            a += b;
        }

        static void Main(string[] args)
        {
            int[] f1 = { 10, 1, 20, 5, 4, 11, 3, 7, 6 };
            Minima(f1);

            string z1 = "42";
            string z2 = "29";
            string sum = Addiere(z1, z2);
            Console.WriteLine(z1);
            Console.WriteLine(z2);
            Console.WriteLine(sum);

            Bug b1 = new Bug("Fehler A");
            Bug b2 = new Bug("Fehler B"); 
            Bug b3 = new Bug("Fehler B", Status.Offen);
            Bug.DuplikateAusgeben(b1, b2, b3);

            for (int i = 1; i<=4; i++)
            {
                for (int j=20+i; j<20+4+i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            int[] arr = {8, 21, 20, 9};
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    if (i >= 0 && i <= 10)
                    {
                        Console.Write("A");
                    }
                }
                else if (i < 0 || i % 3 == 0)
                {
                    Console.Write("B");
                }
                else
                {
                    Console.Write("C");
                }
            }
            int x, y = 3;
            Add(out x, ref y);

            Console.WriteLine($"{x} {y} ");
        }
    }
}
