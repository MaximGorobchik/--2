using System;
using System.Linq;

public class CompareCharArrays
{
    public static void Main()
    {
        Console.Write("Array 1: ");
        char[] array1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
        Console.Write("Array 2: ");
        char[] array2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

        int minLength = Math.Min(array1.Length, array2.Length);

        int biggestArr = 0;
        bool isEqual = true;

        for (int i = 0; i < minLength; i++)
        {
            if (!array1[i].Equals(array2[i]))
            { 
                isEqual = false;
                if (array1[i] > array2[i])
                {
                    biggestArr = 1;
                }
                else
                {
                    biggestArr = 2;
                }
            }
        }

        if ((biggestArr == 2 && !isEqual) || (isEqual && array1.Length <= array2.Length))
        {
            Console.WriteLine(string.Join(string.Empty, array1));
            Console.WriteLine(string.Join(string.Empty, array2));
        }
        else if ((biggestArr == 1 && !isEqual) || (isEqual && array1.Length > array2.Length))
        {
            Console.WriteLine(string.Join(string.Empty, array2));
            Console.WriteLine(string.Join(string.Empty, array1));
        }
    }
}