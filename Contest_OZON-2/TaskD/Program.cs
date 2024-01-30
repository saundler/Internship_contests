using System;

namespace TaskD;

class  Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()), m, k;
        string str;
        Tuple<int, int> ans;
        for (; n > 0; --n)
        {
            ans = new Tuple<int, int>(15, 30);
            m = int.Parse(Console.ReadLine());
            for (; m > 0; --m)
            {
                str = Console.ReadLine();
                k = int.Parse(str.Split(" ").ToArray()[1]);
                if (str[0] == '>' && ans.Item1 < k)
                {
                    ans = Tuple.Create(k, ans.Item2);
                } 
                else if (str[0] == '<' && ans.Item2 > k)
                {
                    ans = Tuple.Create(ans.Item1, k);
                }
                if (ans.Item1 > ans.Item2)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine(ans.Item1);
                }
            }
            Console.WriteLine();
        }
    }
}