using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2.Rotate_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine();
            Console.Write("How many times rotate array: ");
            int Rotated = int.Parse(Console.ReadLine());
            int[] sum = new int[array.Length];
            rotate(array, Rotated, sum);
            Console.WriteLine(string.Join(" ", sum));
        }

        static void rotate(int[] x, int count, int[] y)
        {
            for (int i = 0; i < count; i++)
            {
                RotatingArray(x);
                suma(x, y);
            }
        }
        static void suma(int[] x, int[] y)
        {
            for (int i = 0; i < y.Length; i++)
            {
                y[i] += x[i];
            }
        }
        static void RotatingArray(int[] x)
        {
            int lastNum = x[x.Length - 1];

            for (int i = x.Length - 1; i > 0; i--)
            {
                x[i] = x[i - 1];
            }

            x[0] = lastNum;
        }

    }
}
