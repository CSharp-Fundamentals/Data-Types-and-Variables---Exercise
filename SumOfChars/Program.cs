using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < num; i++)
            {
                char n = char.Parse(Console.ReadLine());
                sum += n;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
