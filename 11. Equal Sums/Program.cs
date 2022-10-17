using System;
using System.Linq;

public class EqualSums
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        bool hasEqualSum = false;
        int leftsum=0;
        int rightsum=0;
        for (int i = 0; i < numbers.Length; i++)
        {
            leftsum = numbers.Take(i).Sum();
            rightsum = numbers.Skip(i + 1).Sum();
            if (leftsum == rightsum)
            {
                Console.WriteLine("["+i+"]");
                hasEqualSum = true;
                break;
            }
        }

        if (leftsum != rightsum)
        {
            Console.WriteLine("no");
        }
    }
}