using System;
using System.Linq;

public class MostFrequentNumber
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int maxCount = 0;
        int mostFrequentNum = 0;

        for (int i = 0; i < numbers.Length-1; i++)
        {
            int count = numbers.Count(x => x == i);
            if (count > maxCount)
            {
                maxCount = count;
                mostFrequentNum = i;
            }

        }
        Console.WriteLine("The number " + mostFrequentNum + " is the most frequent (occurs " + maxCount + " times" + ")");
    }
}