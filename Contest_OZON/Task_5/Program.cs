using System;

namespace Task_5
{
    internal class Program
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            int[] Arr;
            List<int> list;
            bool flag;
            for (int i = 0; i < t; i++)
            {
                Console.ReadLine();
                Arr = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                list = new List<int>();
                flag = true;
                for(int j = 0; j < Arr.Length; j++)
                {
                    if (j == 0 || Arr[j] != Arr[j- 1])
                    {
                        if (!list.Contains(Arr[j]))
                        {
                            list.Add(Arr[j]);
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                if(flag)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}