using System;
using System.IO;

namespace _11._2._Filter_Funktion__Klausur_SoSe_2015_
{
    class Program
    {
        static int Filter(string datei1, string datei2)
        {
            StreamReader sr1 = new StreamReader(datei1);
            StreamWriter sw2 = new StreamWriter(datei2);
            
            int zaehler = 0;

            while (!sr1.EndOfStream)
            {
                bool gibtsZiffer = false;
                string zeile = sr1.ReadLine();
                foreach (char c in zeile)
                {
                    if (c >= '0' && c <= '9')
                    {
                        gibtsZiffer = true;
                        break;
                    }
                }
                if (gibtsZiffer)
                    sw2.WriteLine(zeile);
                if (!gibtsZiffer)
                    zaehler++;
            }
            sr1.Close();
            sw2.Close();

            return zaehler;
        }
        static void Main(string[] args)
        {
            int anzahl = Filter(@"..\..\..\input.txt", @"..\..\..\output.txt");

            Console.WriteLine($"{anzahl} Zeilen gefiltert.");
            //string datei01 = (@"..\..\..\input.txt");
            //string datei02 = (@"..\..\..\output.txt");
            //Console.WriteLine(Filter(datei01, datei02) + " Zeilen gefiltert.");
        }
    }
}