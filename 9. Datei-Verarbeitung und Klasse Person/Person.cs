using System;
using System.Collections.Generic;
using System.Text;

namespace _9._Datei_Verarbeitung_und_Klasse_Person
{
    class Person
    {
        static int zaehler = 0;
        int persnr;
        string vorname;
        string nachname;
        string email;

        public Person(string Vorname, string Nachname, string Email) 
        {
            ++zaehler;
            persnr = zaehler;
            if (Vorname.Length<2)
            {
                throw new ArgumentOutOfRangeException();
            }
            vorname = Vorname;
            if (Nachname.Length < 2)
            {
                throw new ArgumentOutOfRangeException();
            }
            nachname = Nachname;

            if (EmailGueltig(Email))
            {
                email = Email;
            }
            else
            {
                 throw new ArgumentException("Email ist ungueltig");
            }
        }

        public string Name
        {
            get
            {
                return nachname + " " + vorname;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (EmailGueltig(value))
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("Email ist ungueltig");
                }
            }
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string Email)
        {
            if (EmailGueltig(Email))
            {
                email = Email;
            } else
            {
                throw new ArgumentException("Email ist ungueltig");
            }
        }

        public bool EmailGueltig(string Email)
        {
            if (Email == null || Email.Length == 0)
                return false;

            bool atGefunden = false;

            for (int i = 0; i < Email.Length; i++) 
            {
                if (Email[i] == ' ')
                    return false;
                else if (!(Email[i]<='A' && Email[i]>='Z') 
                    || !(Email[i]<='a' && Email[i]>='z'))
                {
                    return false;
                } 
                else if (Email[i]=='@')
                {
                    atGefunden = true;
                }
                if (atGefunden && Email[i]=='.')
                {
                    return true;
                }
                
            }
            return true;
        }

        public override string ToString()
        {
            return nachname + ", " + vorname + "; " + email;
        }
    }
}
