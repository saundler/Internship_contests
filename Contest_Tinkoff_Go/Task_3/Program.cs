using System;

namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            Console.ReadLine();
            int[] AS = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(),
                  AN = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.ReadLine();
            int[] BS = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(),
                  BN = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string str1 = "", str2 = "";
            int n = 0;
            for(int i = 0; i < AS.Length; i++)
            {
                for(int j = 0; j < AN[i]; j++)
                {
                    if (AS[i] == 1)
                        str1 += '1';
                    else
                        str1 += '0';
                }
            }
            for (int i = 0; i < BS.Length; i++)
            {
                for (int j = 0; j < BN[i]; j++)
                {
                    if (BS[i] == 1)
                        str2 += '1';
                    else
                        str2 += '0';
                }
            }
            for(int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                    n += i + 1;
            }
            Console.WriteLine(n);
        }
    }
}