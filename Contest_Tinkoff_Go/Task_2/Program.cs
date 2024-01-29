using System;

namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()),
                k = int.Parse(Console.ReadLine());
            int min = 0, max = 0;
            max = (n - k + 1) * (n - k + 1) + k - 1;
            while (k > 0)
            {
                min += (n / k) * (n / k);
                n -= n / k;
                k -= 1;
            }
            Console.WriteLine(min + " " + max);
        }
    }
}