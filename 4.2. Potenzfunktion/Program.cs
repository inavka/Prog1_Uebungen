using System;

namespace _4._2._Potenzfunktion
{
    class Program
    {
        static double Potenz(double x, int n)
        {
            
            double newX = 1;
            if (n < 0)
            {
                //for(int i=n;i<0;i++)
                //{
                //    newX= 
                //}
            }
            for (int i=1; i<=n; i++)
            {
                newX = newX * x;
                Console.WriteLine($"{x}^{i}: {newX}");
            }
            return newX;
        }
        static void Main(string[] args)
        {
            Console.Write("Basis eingeben: ");
            double bas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Exponent eingeben: ");
            int exp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{bas}^{exp} = {Potenz(bas, exp)}");
        }
    }
}
