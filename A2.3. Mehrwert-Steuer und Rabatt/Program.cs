using System;

namespace A2._3._Mehrwert_Steuer_und_Rabatt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Betrag eingeben: ");
            double betrag = Convert.ToDouble(Console.ReadLine());
            double mwst = 0.19;
            double gesamt = betrag * mwst;
            Console.WriteLine($"Betrag: {betrag,8:f2}");
            Console.WriteLine($"Mwst: {mwst*100,10:f2}");
            Console.WriteLine("------------------");
            Console.WriteLine($"Gesamt: {gesamt,8:f2}");

            Console.Write("\nNettobetrag eingeben: ");
            double netto = Convert.ToDouble(Console.ReadLine());
            double rabatt = 0.03;
            Console.Write("Vorauszahlung mit 3% Rabatt (ja/nein): ");
            string antwort = Console.ReadLine();

            if (antwort == "ja")
            {
                rabatt *= netto;
            } else
            {
                rabatt = 0;
            }
            mwst *= (netto-rabatt);
            gesamt = netto - rabatt + mwst;
            Console.WriteLine($"Betrag: {netto,8:f2}");
            Console.WriteLine($"Rabatt: {-rabatt,8:f2}");
            Console.WriteLine($"Mwst: {mwst,10:f2}");
            Console.WriteLine("------------------");
            Console.WriteLine($"Gesamt: {gesamt,8:f2}");




        }
    }
}
