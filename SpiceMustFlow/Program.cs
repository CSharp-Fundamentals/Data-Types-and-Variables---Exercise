using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            long sum = 0;
            int days = 0;

            if (startingYield < 100)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
                return;
            }
                while (startingYield >= 100)
                {
                    sum += startingYield - 26;
                    startingYield -= 10;
                    days++;
                }
                sum -= 26;
            Console.WriteLine(days);
            Console.WriteLine(sum);
        }
    }
}
