using System;

namespace Task_2
{
    class Pair
    { 
        public int Value { get; set; }
        public int Count { get; set; }
        public Pair(int value)
        {
            Value = value;
            Count = 1;
        }
     }
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()), sum;
            int[] Arr; 
            List<Pair> pairs;
            for(int i = 0; i < n; i++)
            {
                Console.ReadLine();
                Arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Array.Sort(Arr);
                pairs = new List<Pair>();
                for (int j = 0; j < Arr.Length; j++)
                {
                    if (j == 0 || Arr[j] != Arr[j - 1])
                        pairs.Add(new Pair(Arr[j]));
                    else
                        pairs[^1].Count++;
                }
                sum = 0;
                foreach(Pair pair in pairs)
                {
                    sum += pair.Value * (pair.Count - (pair.Count / 3));
                }
                Console.WriteLine(sum);
            }
        }
    }
}