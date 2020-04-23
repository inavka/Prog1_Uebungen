using System;

namespace _7._2._Flip
{
    class Program
    {
        static string Flip(string s1, char c)
        {
            string s2 = "";

            for(int i = 0; i<s1.Length; i++)
            {
                char n = s1[i];
                if (c == n)
                {
                    if (Char.IsLower(c))
                        n = Char.ToUpper(c);
                    else if (Char.IsUpper(c))
                        n = Char.ToLower(c);
                   
                }
                s2 = s2 + n;
            }
            return s2;
        }
        //static string Flip2(string s1, char c)
        //{
        //    string s2 = "";

        //    for (int i = 0; i < s1.Length; i++)
        //    {
        //        char n = s1[i];
        //        if (c == n)
        //        {
        //            if (c < 'A' && c > 'Z')
        //                n = (char)(c-'A'+'a');
        //            else if (c < 'a' && c > 'z')
        //                n = (char)(c - 'a'+'A');
        //        }
        //        s2 = s2 + n;
        //    }
        //        return s2;
        //}

        static void Main(string[] args)
        {
            string eingabe = "Heute gibt es Eis! Morgen gibt es Reis.";
            Console.WriteLine(Flip(eingabe, 'e'));

            Console.WriteLine(Flip2(eingabe, 'e'));
        }
    }
}
