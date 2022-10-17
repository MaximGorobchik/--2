using System;
using System.Linq;

public class MaxSequenceOfEqualElements
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int bestlen = -1;
        int endIndex = 0;
        int len = 0;

        for (int i = 0; i < numbers.Length-1; i++)
        {
                if (numbers[i] == numbers[i + 1])
                {
                    len++;
                    if (i + 1 == numbers.Length - 1 && bestlen < len)
                    {
                        bestlen = len;
                        endIndex = i + 1;
                    }
                }
                else
                {
                    if (bestlen < len)
                    {
                        bestlen = len;

                        endIndex = i;
                    }

                    len = 0;
                }
        }
        for (int i=0;i<bestlen+1;i++)
        {
            Console.Write(numbers[endIndex] + " ");
        }
    }

}