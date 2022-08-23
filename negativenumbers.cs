using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class negativenumbers
    {
        public static void Main()
        {
            int[] arr = { 12, -84, 2, -78, -54, 37 };
            int i, n;
            n = arr.Length;
            for (i = 1; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    Console.Write($"{arr[i]}");
                }

            }
        }
    }
}
