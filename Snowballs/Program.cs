using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger maxValue = 0;
            int outputSnow = 0;
            int outputTime = 0;
            int outputQuality = 0;

            for (int i = 1; i <= n; i++)
            {
               int snowballSnow = int.Parse(Console.ReadLine());
               int snowballTime = int.Parse(Console.ReadLine());
               int snowballQuality = int.Parse(Console.ReadLine());

               BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (maxValue<snowballValue)
                {
                    maxValue = snowballValue;
                    outputSnow = snowballSnow;
                    outputTime = snowballTime;
                    outputQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{outputSnow} : {outputTime} = {maxValue} ({outputQuality})");
        }
    }
}
