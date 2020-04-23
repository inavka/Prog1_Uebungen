using System;

namespace Quersumme__iterativ_und_rekursiv_
{
    class Program
    {
        static int QuersummeIterativ(int n)
        {
            int qsum = 0;

            if (n < 0)
                return -1;
            do
            {
                qsum += n % 10;
                n = n / 10;
            } while (n > 0);
            return qsum;
        }

        static int QuersummeRekursiv (int n)
        {
            int sum = 0;
                if (n<10)
            {
                sum = n;
            } else
            {
                sum = n % 10 + QuersummeRekursiv(n / 10);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int z = 34567;
            int sum = QuersummeIterativ(z);
            Console.WriteLine($"{z} --> {sum}");
            int sum2 = QuersummeRekursiv(z);
            Console.WriteLine($"{z} --> 2. {sum2}");
        }
    }
}
