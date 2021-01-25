using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());

            for (int i = start; i <= finish; i++)
            {
                char current = (char)i;
                Console.Write(current+" ");
            }
        }
    }
}
