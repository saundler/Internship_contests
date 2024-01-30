using System;

namespace TaskE;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (; n > 0; --n)
        {
            int m = int.Parse(Console.ReadLine()), cnt = 0, k = 0;
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            List<int> ans = new List<int>();
            for (int i = 0; i < m; ++i)
            {
                if (i == 0)
                {
                    ans.Add(arr[0]);
                    ++k;
                }
                else if ((cnt > 0 && arr[i - 1] != arr[i] - 1) || (cnt < 0 && arr[i - 1] != arr[i] + 1))
                {
                    ans.Add(cnt);
                    ans.Add(arr[i]);
                    cnt = 0;
                    ++k;
                }
                else if (arr[i - 1] == arr[i] - 1)
                {
                    ++cnt;
                }
                else if (arr[i - 1] == arr[i] + 1)
                {
                    --cnt;
                }
                else
                {
                    ans.Add(cnt);
                    ans.Add(arr[i]);
                    ++k;
                }
                if (i + 1 == m)
                {
                    ans.Add(cnt);
                }
            }

            Console.WriteLine(k * 2);
            Console.WriteLine(string.Join(" ", ans));
        }
    }
}