using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Merge
    {
        static void Main()
        {
            int i = 0;
            int j = 0;

            int[] arr1 = new int[5] { 2 , 4 , 6 , 8 , 15 };

            int[] arr2 = new int[5] { 22 , 34 , 41 , 50 , 66 };

            int[] merge = new int[10];

            for (i = 0, j = 0; i < 5; i++)
            {
                merge[j++] = arr1[i];
            }
            for (i = 0; i < 5; i++)
            {
                merge[j++] = arr2[i];
            }
            Console.WriteLine("Elements of merged array = ");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("merge[" + (i) + "]: " + merge[i]);
            }
            Console.WriteLine();
        }
    }
}
