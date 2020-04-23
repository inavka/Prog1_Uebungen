using System;

namespace _6._2._Felder_in_2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zeilen: ");
            int zeilen = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nSpalten: ");
            int spalten = Convert.ToInt32(Console.ReadLine());

            int[,] f = new int[zeilen, spalten];
            Random rand = new Random();
            int sum=0;
           
            for (int i = 0; i < f.GetLength(0); i++)
            {
                for (int j =0; j<f.GetLength(1); j++)
                {
                    f[i, j] = rand.Next(1, 5);
                    Console.Write($"{f[i,j]} ");
                }
                Console.WriteLine( );
            }
            int[] sumList = new int[spalten];

            for (int j = 0; j<f.GetLength(1);j++)
            {
                for (int i = 0; i <f.GetLength(0); i++)
                {
                    sum += f[i, j];
                }
                sumList[j] = sum;
                sum = 0;
            }
            Console.WriteLine("============");
            for (int a = 0; a< sumList.Length; a++)
            {
                Console.Write($"{sumList[a]} " );
            }
        }
    }
}
