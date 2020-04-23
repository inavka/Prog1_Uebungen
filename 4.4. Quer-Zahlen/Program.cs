using System;

namespace _4._4._Quer_Zahlen
{
    class Program
    {
        static int Quersumme (int z)
        {
            int sum=0;
            while(z!=0)
            {
                sum += z % 10;
                z = z / 10;
            }
            return sum;
        }

        static int Querprodukt(int z)
        {
            int produkt=1;
            while (z != 0)
            {
                produkt *= z % 10;
                z = z / 10;
            }
            return produkt;
        }
        static void Main(string[] args)
        {
            Console.Write("Zahl: ");
            int zahl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quersumme: "+Quersumme(zahl));
            Console.WriteLine("Querprodukt: "+Querprodukt(zahl));
            Console.WriteLine("Zahlen, bei denen die Summe aus Quersumme und Querprodukt gleich der Zahl ist:");
            for(int i=1; i<1000; i++)
            {
                if(i==Quersumme(i)+Querprodukt(i))
                    Console.WriteLine(i);
            }
        }
    }
}
