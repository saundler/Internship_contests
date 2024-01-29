using System.Linq;
using System;

namespace Task_6
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(),
                  brr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = 0, m, k = arr[1];
            for(int i = 0; k > 0;)
            {
                n++;
                k -= brr[i];
                if (i < brr.Length)
                    i++;
            }

        }
    }
}