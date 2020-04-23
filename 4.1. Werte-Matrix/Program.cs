using System;

namespace _4._1._Werte_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n eingeben: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int zaehler = 0;
            for (int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    int a = j - zaehler;
                    Console.Write($"{(a),4}");
                   
                }
                Console.WriteLine();
                zaehler++;
            }
        }
    }
}
