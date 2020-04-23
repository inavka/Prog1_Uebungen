using System;
using System.Collections.Generic;
using System.Text;

namespace _9._Datei_Verarbeitung_und_Klasse_Person
{
    class Abteilung
    {
        string abteilung;
        Person[] mitarbeiter;

        public Abteilung(string AbteilungName, params Person[] Mitarbeiter)
        {
            abteilung = AbteilungName;
            mitarbeiter = Mitarbeiter;
        }
        public override string ToString()
        {
            return abteilung + "(" + mitarbeiter.Length + ")";
        }
         public void Ausgabe()
        {
            Console.WriteLine(this);
            //Console.WriteLine($"{abteilung}({mitarbeiter.Length})");
            for (int i = 0; i < mitarbeiter.Length; i++)
            {
                Console.WriteLine(mitarbeiter[i]);
            }
        }
    }
}
