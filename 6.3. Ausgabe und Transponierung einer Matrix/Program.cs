using System;

namespace _6._3._Ausgabe_und_Transponierung_einer_Matrix
{
    class Program
    {
        static void Ausgabe(int [,] matrix)
        {
            for (int i = 0; i<matrix.GetLength(0); i++)
            {
                for(int j = 0; j<matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        static int[,] Transponiere(int[,]matrix)
        {
            int z = matrix.GetLength(0);
            int s = matrix.GetLength(1);
            int[,] matrixNeu = new int[s, z];

            for(int i = 0; i<matrix.GetLength(0); i++)
            {
                for(int j = 0; j<matrix.GetLength(1);j++)
                {
                    matrixNeu[j, i] = matrix[i, j];
                }
            }
            return matrixNeu;
        }
        static void Main(string[] args)
        {
            int[,] f = { { 11, 12 }, { 21, 22 }, { 31, 32 } };
            Console.WriteLine("Original");
            Ausgabe(f);
            int[,] f2 = Transponiere(f);
            Console.WriteLine("Transponiert:");
            Ausgabe(f2);

        }
    }
}
