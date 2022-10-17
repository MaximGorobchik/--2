using System;
using System.Text;

public class SieveOfEratosthenes
{
    public static void Main()
    {
        Console.Write("Enter n: ");
        int number = int.Parse(Console.ReadLine());
        int divisors = 0; bool flag = true;
        for (int i = 2; i <=number; i++)
        {
            for (int j = 2; j<i; j++)
            {
                if ((i % j) == 0)
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                Console.Write(i + " ");
            }
            flag = true;
        }
    }


}