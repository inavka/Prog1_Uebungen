using System;

namespace A_8._1._Klasse_Bruch
{
    class Bruch
    {
        private int zaehler;
        private int nenner;

        public int GetZaehler()
        {
            return zaehler;
        }
        public void SetZaehler(int z)
        {
            zaehler = z;
            Kuerzen();
        }

        public int Z
        {
            get
            {
                return zaehler;
            }
            set
            {
                zaehler = value;
                Kuerzen();
            }
        }

        public int GetNenner()
        {
            return nenner;
        }

        public void SetNenner(int n)
        {
            if (n==0)
            {
                throw new ArgumentException();
            }
            nenner = n;
            Kuerzen();
        }

        public int N
        {
            get
            {
                return nenner;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException();
                }
                nenner = value;
                Kuerzen();
            }
        }
        public Bruch() {
            zaehler = 0;
            nenner = 1;
        }
        public Bruch (int Zaehler, int Nenner)
        {
            zaehler = Zaehler;
            if (Nenner == 0)
            {
                throw new ArgumentException();
            }
            nenner = Nenner;
            Kuerzen();
        }

        public override string ToString()
        {
            if (nenner==1)
            {
                return Convert.ToString(zaehler);
            }
            else
            {
                return zaehler + "/" + nenner;
            }
        }

        public Bruch Mult(Bruch b)
        {
            Bruch produkt = new Bruch();
            produkt.zaehler = zaehler * b.zaehler;
            produkt.nenner = nenner * b.nenner;
            produkt.Kuerzen();

            return produkt;
        }

        public Bruch Add(Bruch b)
        {
            Bruch summe = new Bruch();
            summe.zaehler = zaehler * b.nenner + b.zaehler * nenner;
            summe.nenner = nenner * b.nenner;
            summe.Kuerzen();
            return summe;
        }

        public void Kuerzen()
        {

            int a = zaehler;
            int b = nenner;

            int ggt;

            if (a == 0)
            {
                ggt = b;
            }
            else
            {
                while (b != 0)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }
                ggt = a;
            }
            zaehler /= ggt;
            nenner /= ggt;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bruch b1 = new Bruch();
            b1.SetZaehler(4);
            b1.SetNenner(3);
            Console.WriteLine($"b1 = {b1.GetZaehler()}/{b1.GetNenner()}");

            Bruch b2 = new Bruch(3, 2);
            Console.WriteLine($"b2 = {b2.GetZaehler()}/{b2.GetNenner()}");
            
            Bruch b3 = new Bruch();
            Console.WriteLine($"b3 = {b3.GetZaehler()}/{b3.GetNenner()}");

            Console.WriteLine("b1 = " + b1);
            Console.WriteLine("b2 = " + b2);
            Console.WriteLine("b3 = " + b3);

            Console.WriteLine("b1 * b2 = "+ b1.Mult(b2));

            Bruch b4 = new Bruch(6, 4);
            Console.WriteLine("b4 =" + b4);

            Bruch b5 = new Bruch(84, 35);
            Console.WriteLine("b5 =" + b5);

            Console.WriteLine("b5*b4 =" + b4.Mult(b5));

            Bruch b6 = new Bruch(4, 3);
            Bruch b7 = new Bruch(3, 2);
            Bruch b8 = b6.Add(b7);
            Console.WriteLine("b6+b7 = " + b8);
            Console.WriteLine("b6+b7 = " + b8.Add(new Bruch(1,6)));
        }
    }
}