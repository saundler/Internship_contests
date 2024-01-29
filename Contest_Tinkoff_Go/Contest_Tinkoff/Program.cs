using System;
using System.Linq;

namespace Task_1
{
    internal class Program
    {
        public static int FindPlace(bool[] places, bool d, int n)
        {
            int c = places.Length / 2;
            if(places.Length % 2 == 1)
            {
                if (d)
                {
                    if (!places[c - n])
                    {
                        places[c - n] = true;
                        return c - n + 1;
                    }
                    else
                        return FindPlace(places, false, n);
                }
                else
                {
                    if (!places[c + n])
                    {
                        places[c + n] = true;
                        return c + n + 1;

                    }
                    else
                        return FindPlace(places, true, ++n);
                }
            }
            else
            {
                --c;
                if (d)
                {
                    if (c + n < places.Length && !places[c + n])
                    {
                        places[c + n] = true;
                        return c + n + 1;
                    }
                    else
                        return FindPlace(places, false, n);
                }
                else
                {
                    if (!places[c - n])
                    {
                        places[c - n] = true;
                        return c - n + 1;

                    }
                    else
                        return FindPlace(places, true, ++n);
                }
            }
        }
        static void Main()
        {
            int[] Arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(),
                  por = new int[Arr[1]];
            int n = Arr[0], m = Arr[1];
            bool[] places = new bool[m];
            for (int i = 0; i < m; i++)
                por[i] = FindPlace(places, true, 0);
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(por[k]); 
                if (k + 1 == m)
                    k = 0;
                else
                    k++;
            }
        }
    }
}