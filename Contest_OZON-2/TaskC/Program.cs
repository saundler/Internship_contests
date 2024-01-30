using System;

namespace TaskC;

class  Program
{
    static void Main(string[] args)
    {
        int m = int.Parse(Console.ReadLine());
        string str, ans;
        for (; m > 0; --m)
        {
            int l = 0, n = 0;
            ans = "";
            str = Console.ReadLine();
            foreach (var c in str)
            {
                if ((47 < c && c < 58 && l == 1 && n < 2))
                {
                    ans += c;
                    ++n;
                }
                else if (!(47 < c && c < 58) && (l == 0 || (n < 3 && l < 3)))
                {
                    ans += c;
                    ++l;
                }
                else
                {
                    l = -1;
                    break;
                }
                if (0 < n && n < 3 && l == 3)
                {
                    ans += " ";
                    l = 0;
                    n = 0;
                }
            }
            if (l == 0 && n == 0)
            {
                Console.WriteLine(ans);
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}

