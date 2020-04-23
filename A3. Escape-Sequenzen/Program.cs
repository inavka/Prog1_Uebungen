using System;

namespace A3._Escape_Sequenzen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Die Datei finden Sie im Verzeichnis C:\\uebung\\c\\neu\\aufgabe1");
            Console.WriteLine("Es gibt in C# das Hochkomma \"\'\" und das Anführungszeichen \"\"\"!");

            int[] a1 = { 2, 4, 10, 20, 25 };
            int[] a2 = { 1, 2, 3, 7, 10, 11, 20 };

            // define a third integer array
            int[] a3 = new int[a1.Length + a2.Length];

            // What does the rest of the code?
            for (int i1 = 0, i2 = 0, i3 = 0, e1 = a1.Length, e2 = a2.Length, e3 = e1 + e2; i3 < e3; ++i3)
            {
                a3[i3] = i2 >= e2 || i1 < e1 && a1[i1] < a2[i2] ? a1[i1++] : a2[i2++];
            }

            Console.WriteLine(string.Join(" ", a3));



            int i, j;
            int[,] arr = new int[2, 2];
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    arr[i, j] = i * 17 + i * 17;
                    Console.Write(arr[i, j] + " ");
                }
            }



        }
    }
}
