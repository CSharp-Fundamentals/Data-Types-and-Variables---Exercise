using System;

namespace WaterKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string model = String.Empty;
            double radius = 0;
            int height = 0;
            double volume = 0;
            double maxVol = double.MinValue;
            string bigger = String.Empty;

            for (int i = 1; i <= n; i++)
            {
                model = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                volume = Math.PI * (radius * radius) * height;
                if (volume>maxVol)
                {
                    maxVol = volume;
                    bigger = model;
                }
            }
            Console.WriteLine(bigger);
        }
    }
}
