using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laba2ООП
{
    internal class Program
    {
        static void Main()
        {
            string[] FirstLine; string[] SecondLine;
            Console.Write("First line: "); FirstLine = Console.ReadLine().Split().ToArray();
            Console.Write("Second line: "); SecondLine = Console.ReadLine().Split().ToArray();
            int MinLength = Math.Min(FirstLine.Length, SecondLine.Length);
            int i;
            int MaxLength(string[] x, string[] y, int z)
            {
                int counter = 0;
                for (i = 0; i < z; i++)
                {
                    if (x[i].Equals(y[i]))
                    {
                        counter++;
                        Console.Write(x[i] + " ");
                    }
                    else
                    {
                        break;
                    }
                }
                return counter;
            }
            int Length1 = MaxLength(FirstLine, SecondLine, MinLength);
            Array.Reverse(FirstLine); Array.Reverse(SecondLine);
            int Length2 = MaxLength(FirstLine, SecondLine, MinLength);
            if (Length1 > Length2)
            {

                Console.WriteLine(" " + "[" + Length1 + "]");
            }
            else
            {
                Console.WriteLine(Length2);
            }
        }
    }
}
