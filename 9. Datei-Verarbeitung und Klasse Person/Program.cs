using System;
using System.IO;

namespace _9._Datei_Verarbeitung_und_Klasse_Person
{
    class Program
    {
        static int DateiSumme(string name)
        {
            int summe = 0;
            StreamReader sr = new StreamReader(name);
            while (!sr.EndOfStream)
            {
                summe += Convert.ToInt32(sr.ReadLine());   
            }
            return summe;
        }
        static void Main(string[] args)
        {
            int summe = DateiSumme(@"..\..\..\zahlen.txt");
            Console.WriteLine($"Summe ist {summe}");

            //Person person = new Person(463, "Anne", "Meier", "ameier@thn.de");
            //Console.WriteLine(person.Name);
            //Console.WriteLine(person);
            //person.Email = "ameier@th-nuernberg.de"; // Ändern der Email
            //Console.WriteLine(person);

            Person person = new Person("Anne", "Meier", "ameier@thn.de");
            Console.WriteLine(person.Name);
            Console.WriteLine(person);
            person.Email = "ameier@th-nuernberg.de"; // Ändern der Email
            Console.WriteLine(person);

            // Test für Anlage einer Abteilung
            Person[] mitarbeiterPR = new Person[6];
            mitarbeiterPR[0] = new Person("Donald", "Duck", "dd@entenhausen.com");
            mitarbeiterPR[1] = new Person("Gustav", "Gans", "gg@entenhausen.com");
            mitarbeiterPR[2] = new Person("Micky", "Maus", "mm@entenhausen.com");
            mitarbeiterPR[3] = new Person("Duffy", "Duck", "dd@warner.com");
            mitarbeiterPR[4] = new Person("Silvester", "Cat", "silly@cat.org");
            mitarbeiterPR[5] = new Person("Tweety", "Bird", "birdy@twitter.com");
            Abteilung pr = new Abteilung("Public Relations", mitarbeiterPR);
            Console.WriteLine(pr);
            pr.Ausgabe();
            Console.WriteLine();
            string[] emails = { "ameier@thn.de", "ab.xyz@web", "@123.de", "thn.de", "darth vader@empire.com" };
        }

    }
}
