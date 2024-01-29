using System;
using System.Linq;

namespace TaskA
{
    internal class Program
    {
        public static bool IsCorrect(ref int[] arr)
        {
            for (int i = 0; i < 4; ++i)
            {
                if (arr[i] != 4 - i)
                {
                    return false;
                }
            }
            return true;
        }
        
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr, tmp;
            for (; 0 < n; --n)
            {
                tmp = new int[4];
                arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                foreach (int i in arr)
                {
                    ++tmp[i - 1];
                }

                if (IsCorrect(ref tmp))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}