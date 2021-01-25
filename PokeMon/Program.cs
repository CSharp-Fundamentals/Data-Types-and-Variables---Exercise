using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int origin = n;
            int counter = 0;

            while (m <= n)
            {
                n -= m;
                counter++;
                if (n == origin / 2 && y>0)
                { 
                     n /= y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(counter);
        }
    }
}