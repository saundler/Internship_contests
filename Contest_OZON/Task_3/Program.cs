using System;

namespace Task_3
{
    class Developer
    {
        public int Number { get; set; }
        public int Skill { get; set; }
        public Developer(int number, int skill)
        {
            Number = number;
            Skill = skill;
        }
    }
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] Arr, Key = new int[2];
            List<Developer> developers;
            for (int i = 0; i < n; i++)
            {
                Console.ReadLine();
                Arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                developers = new List<Developer>();
                for (int j = 0; j < Arr.Length; j++)
                    developers.Add(new Developer(j + 1, Arr[j]));
                while (developers.Count > 0)
                {
                    Key[0] = 101;
                    Key[1] = 51;
                    for(int j = 1; j < developers.Count; j++)
                    {
                        if (Key[0] > Math.Abs(developers[0].Skill - developers[j].Skill))
                        {
                            Key[0] = Math.Abs(developers[0].Skill - developers[j].Skill);
                            Key[1] = j;
                        }
                    }
                    Console.WriteLine(developers[0].Number + " " + developers[Key[1]].Number);
                    developers.RemoveAt(Key[1]);
                    developers.RemoveAt(0);
                }
            }
        }
    }
}