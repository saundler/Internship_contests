using System;
using System.IO;

namespace Task_4
{
    internal class Program
    {
        public static void Bubble_Sort(int[][] anArray, Comparison<int[]> a)
        {
            int[] k; 
            for (int i = 0; i < anArray.Length; i++)
            {
                for (int j = 0; j < anArray.Length - 1 - i; j++)
                {
                    if (a(anArray[j], anArray[j + 1]) > 0)
                    {
                        k = anArray[j];
                        anArray[j] = anArray[j + 1];
                        anArray[j + 1] = k;
                    }
                }
            }
        }
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            int[] nm, column;
            int[][] Matrix;
            for (int i = 0; i < t; i++)
            {
                Console.ReadLine();
                nm = Array.ConvertAll(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
                Matrix = new int[nm[0]][];
                for(int j = 0; j < nm[0]; j++)
                    Matrix[j] = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                Console.ReadLine();
                column = Array.ConvertAll(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
                for (int j = 0; j < column.Length; j++)
                    Bubble_Sort(Matrix, (int[] a, int[] b) => { return a[column[j] - 1] - b[column[j] - 1]; });
                for (int j = 0; j < nm[0]; j++)
                    Console.WriteLine(string.Join(' ', Matrix[j]));
            }
        }
    }
}