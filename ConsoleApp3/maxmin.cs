using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class maxmin
    {
        public static void Main()
        {
            int[] arr ={ 10,45,51,1,5 };
            int i, max, min, n;
            n = arr.Length;
            max = arr[0];
            min = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("Maximum Number = {0}\n", max);
            Console.Write("Minimum Number = {0}\n", min);
        }
    }
}
