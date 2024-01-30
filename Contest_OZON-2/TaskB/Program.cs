namespace TaskB;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr;
        for (; n > 0; --n)
        {
            arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            if (((arr[1] == 1 || arr[1] == 3 || arr[1] == 5 || arr[1] == 7 || arr[1] == 8 || arr[1] == 10 ||
                  arr[1] == 12) && arr[0] < 32) ||
                ((arr[1] == 4 || arr[1] == 6 || arr[1] == 9 || arr[1] == 11) && arr[0] < 31) || arr[0] < 29 ||
                (arr[0] == 29 && ((arr[2] % 4 == 0 && arr[2] % 100 != 0) || arr[2] % 400 == 0)
                ))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}