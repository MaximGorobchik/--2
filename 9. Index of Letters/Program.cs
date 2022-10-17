using System;
using System.Diagnostics;
using System.Linq;

public class IndexOfLetters
{
    public static void Main()
    {
        char[] s = Console.ReadLine().Split().Select(char.Parse).ToArray();
        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine(s[i] + " -> " + (int)(s[i] - 97));
        }
    }
}