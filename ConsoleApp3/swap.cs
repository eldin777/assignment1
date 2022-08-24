using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class swap
    {
        public static void Swapnumber(ref int a,ref int b)
        {
            a += b;
            b =a-b;
            a -= b;
        }
        public static void Main()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"Before Swap a={a} b={b}");
            Swapnumber(ref a, ref b);
            Console.WriteLine($"After Swap a={a} b={b}");
        }
    }
}
