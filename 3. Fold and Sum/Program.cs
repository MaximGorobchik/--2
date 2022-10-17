using System;
using System.Linq;

public class FoldAndSum
{
    public static void Main()
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] length1 = array.Take(array.Length / 4).ToArray();
        Array.Reverse(length1);

        int[] lastElements = array
            .Skip(array.Length - (array.Length / 4))
            .Take(array.Length / 4)
            .ToArray();
        Array.Reverse(lastElements);

        int[] concatedElements = length1.Concat(lastElements).ToArray();

        int[] middleElements = array
                   .Skip(array.Length / 4)
                   .Take(array.Length / 2)
                   .ToArray();

        int[] sum = new int[middleElements.Length];

        for (int i = 0; i < sum.Length; i++)
        {
            sum[i] = middleElements[i] + concatedElements[i];
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}