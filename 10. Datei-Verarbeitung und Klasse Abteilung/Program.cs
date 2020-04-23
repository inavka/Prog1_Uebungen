using System;
using System.IO;

namespace _10._Datei_Verarbeitung_und_Klasse_Abteilung
{
    
    class Program
    {
        static void DateiLesen()
        {
            StreamReader sr = new StreamReader(@"..\..\..\verkauf.txt");
            StreamWriter sw = new StreamWriter(@"..\..\..\umsatzbericht.txt");
            int zaehler = 1;
            Console.WriteLine(" Anzahl \t"+ "|\t" + " Artikel \t" +"|\t" + " Preis \t" + "\t");
            Console.WriteLine("--------------------------------------------------------------");
            do
            {
                string zeile = sr.ReadLine();
                string[] daten = zeile.Split(';');
                sw.WriteLine($"{zaehler++}. Artikel: {daten[0]} fuer {daten[1]} Euro");
                int anzahl = 1;
                string ware="";
                if (daten[0]==ware)
                {
                    anzahl++;
                } else
                {

                }
                ware = daten[0];
                double preis = Convert.ToDouble(daten[1]);


            } while (!sr.EndOfStream);
                sw.Close();
            sr.Close();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Aktuelles Verzeichnis:\n" + Directory.GetCurrentDirectory());
            Console.WriteLine();
            DateiLesen();
        }
    }
}
