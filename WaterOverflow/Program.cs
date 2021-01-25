using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity=255;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int quantities = int.Parse(Console.ReadLine());

                if (capacity>=quantities)
                {
                    capacity -= quantities;
                    sum += quantities;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
