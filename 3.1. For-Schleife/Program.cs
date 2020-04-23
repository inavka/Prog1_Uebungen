using System;

namespace _3._1._For_Schleife
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i = 3; i<78; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for( int i = 5; i<=1000; i+=5)
            {
                Console.WriteLine(i);
            }

            for(int i= 100; i>0; i-=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
