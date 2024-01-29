using System;
using System.Linq;

namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            int[] Arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(),
                  P = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<int> list;
            int n = Arr[0], m = Arr[1], k = m - P.Sum(), r;
            if (k < 0)
            {
                Console.WriteLine(-1);
                return;
            }
            if (k == 0)
            {
                Console.WriteLine(P.Length);
                return;
            }
            for(int i = 1; i < P.Length; i++)
            {
                list = new List<int>();
                r = k;
                for(int j = 0; j < i; j++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        while (r > 0)
                            list.Add();
                    }
                }
            }

        }
    }
}