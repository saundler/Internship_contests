using System;
using System.Data.SqlTypes;

namespace Task_7
{ 
    internal class Program
    {
        public static int SortingRule(int[] a, int[] b)
        {
            if(b[1] == a[1])
                return a[0] - b[0];
            return b[1] - a[1];
        }
        static void Main()
        {
            int r;
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(),
                  m;
            List <int> list1, list2;
            int[][] list;
            List<int>[] friends = new List<int>[n[0]];
            for (int i = 0; i < n[0]; i++)
                friends[i] = new List<int>();
            for(int i = 0; i < n[1]; i++)
            {
                m = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                friends[m[0] - 1].Add(m[1]);
                friends[m[1] - 1].Add(m[0]);
            }
            for (int i = 0; i < n[0]; i++)
            {
                list1 = new List<int>();
                list2 = new List<int>();
                for (int j = 0; j < friends[i].Count; j++)
                {
                    for (int k = 0; k < friends[friends[i][j] - 1].Count; k++)
                    {
                        if (friends[friends[i][j] - 1][k] == i + 1 || friends[i].Contains(friends[friends[i][j] - 1][k]))
                            continue;
                        r = list1.IndexOf(friends[friends[i][j] - 1][k]);
                        if (r != -1)
                            list2[r]++;
                        else
                        {
                            list1.Add(friends[friends[i][j] - 1][k]);
                            list2.Add(1);
                        }
                    }
                }
                list = new int[list1.Count][];
                for(int j = 0; j < list1.Count; j++)
                {
                    list[j] = new int[] { list1[j], list2[j] };
                }
                Array.Sort(list, SortingRule);
                for (int j = 0; j < list.Length; j++)
                {
                    if(j != 0 && list[j][1] < list[j - 1][1])
                        break;
                    Console.Write(list[j][0] + " ");
                }
                if (list.Length == 0)
                    Console.Write(0);
                Console.WriteLine();
            }
        }
    }
}
