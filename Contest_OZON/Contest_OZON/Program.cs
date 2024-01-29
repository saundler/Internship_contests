using System;

namespace Contest_OZON
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] Arr;
            for(int i = 0; i < n; i++)
            {
                Arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Console.WriteLine(Arr[0] + Arr[1]);
            }
        }
    }
}