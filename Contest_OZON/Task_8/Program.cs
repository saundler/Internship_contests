using System;
using System.ComponentModel;

namespace Task_8
{
    internal class Program
    {
        public static void IlandsFinder(List<(int, int, bool)> hexagons, int i)
        {
            hexagons[i] = (hexagons[i].Item1, hexagons[i].Item2, true);
            int[] Arr = new int[] { hexagons.IndexOf((hexagons[i].Item1 - 1, hexagons[i].Item2 - 1, false)), 
                                    hexagons.IndexOf((hexagons[i].Item1 - 1, hexagons[i].Item2 + 1, false)),
                                    hexagons.IndexOf((hexagons[i].Item1, hexagons[i].Item2 - 2, false)),
                                    hexagons.IndexOf((hexagons[i].Item1, hexagons[i].Item2 + 2, false)),
                                    hexagons.IndexOf((hexagons[i].Item1 + 1, hexagons[i].Item2 - 1, false)),
                                    hexagons.IndexOf((hexagons[i].Item1 + 1, hexagons[i].Item2 + 1, false))};
            for(int j = 0; j < Arr.Length; j++)
            {
                if (Arr[j] != -1)
                    IlandsFinder(hexagons, Arr[j]);
            }
           
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            int[] Size;
            char[][] Map;
            bool flag;
            List<(char, List<(int, int, bool)>)> Colors;
            for (int i = 0; i < t; i++)
            {
                flag = false;
                Colors = new List<(char, List<(int, int, bool)>)>();
                Size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Map = new char[Size[0]][];
                for(int j = 0; j < Size[0]; j++)
                {
                    Map[j] = Console.ReadLine().ToCharArray();
                    for(int k = j % 2; k < Size[1]; k += 2)
                    {
                        if (Colors.Exists(t => t.Item1 == Map[j][k]))
                            Colors[Colors.FindIndex(t => t.Item1 == Map[j][k])].Item2.Add((j, k, false));
                        else
                            Colors.Add((Map[j][k], new List<(int, int, bool)>() { (j, k, false) }));
                    }
                }
                for(int j = 0; j < Colors.Count; j++)
                {
                    IlandsFinder(Colors[j].Item2, 0);
                    if (Colors[j].Item2.Exists(t => t.Item3 == false))
                    {
                        flag = true;
                        break;
                    }
                }
                if(flag)
                    Console.WriteLine("NO");
                else
                    Console.WriteLine("YES");
            }
        }
    }
}
