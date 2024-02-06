using System;
using System.Net.Sockets;

namespace TaskF;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()), x, y;
        string str;
        for (; n > 0; --n)
        {
            List<List<char>> ans = new List<List<char>>();
            ans.Add(new List<char>());
            str = Console.ReadLine();
            x = 0;
            y = 0;
            foreach (var c in str)
            {
                switch (c)
                {
                    case 'L':
                        if (x > 0)
                        {
                            --x;
                        }

                        break;
                    case 'R':
                        if (x < ans[y].Count)
                        {
                            ++x;
                        }

                        break;
                    case 'U':
                        if (y > 0)
                        {
                            --y;
                            if (ans[y].Count < x)
                            {
                                x = ans[y].Count;
                            }
                        }

                        break;
                    case 'D':
                        if (y < ans.Count - 1)
                        {
                            ++y;
                            if (ans[y].Count < x)
                            {
                                x = ans[y].Count;
                            }
                        }

                        break;
                    case 'B':
                        x = 0;
                        break;
                    case 'E':
                        if (ans[y].Count != 0)
                        {
                            x = ans[y].Count;
                        }
                        else
                        {
                            x = 0;
                        }

                        break;
                    case 'N':
                        ans.Insert(y + 1, new List<char>());
                        for (; x < ans[y].Count;)
                        {
                            ans[y + 1].Add(ans[y][x]);
                            ans[y].RemoveAt(x);
                        }
                        x = 0;
                        ++y;
                        break;
                    default:
                        if ((c > 96 && c < 123) || (47 < c && c < 58))
                        {
                            ans[y].Insert(x, c);
                            ++x;
                        }
                        break;
                }
            }

            foreach (var li in ans)
            {
                Console.WriteLine(string.Join("", li));
            }

            Console.WriteLine('-');
        }
    }
}