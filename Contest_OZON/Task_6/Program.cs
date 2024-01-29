using System;

namespace Task_6
{
    internal class Program
    {
        public static int Refactor(string line)
        {
            int[] times = line.Split(":").Select(int.Parse).ToArray();
            if (times[0] < 0 || times[0] > 23 || times[1] < 0 || times[1] > 59 || times[2] < 0 || times[2] > 59)
                throw new ArgumentException();
            return times[0] * 3600 + times[1] * 60 + times[2];
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine()), n;
            bool flag;
            int[][] Intervals;
            for (int i = 0; i < t; i++)
            {
                flag = false;
                n = int.Parse(Console.ReadLine());
                Intervals = new int[n][];
                for (int j = 0; j < n; j++)
                {
                    try
                    {
                        Intervals[j] = Console.ReadLine().Split('-').Select(Refactor).ToArray();
                        if (Intervals[j][0] > Intervals[j][1])
                            throw new ArgumentException();
                    }
                    catch(ArgumentException)
                    {
                        flag = true;
                    }
                }
                itog:
                if(flag)
                {
                    Console.WriteLine("NO");
                    continue;
                }
                Array.Sort(Intervals, (int[] a, int[] b) => { return a[0] - b[0]; });
                for (int j = 0; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if ((Intervals[j][0] < Intervals[k][0] && Intervals[k][0] <= Intervals[j][1]) ||
                            (Intervals[j][0] > Intervals[k][0] && Intervals[k][1] >= Intervals[j][0]) ||
                            Intervals[j][0] == Intervals[k][0])
                        {
                            flag = true;
                            goto itog;
                        }
                        if (Intervals[k][0] > Intervals[j][1])
                            break;
                    }
                }
                Console.WriteLine("YES");
            }
        }
    }
}
