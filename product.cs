using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class product
    {

        public static int Multiply(int a1, int b1, int c1)
        {
            return a1 * b1 * c1;
        }
        public static void Main()
        {
            int a, b, c;
            Console.Write("First number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third number");
            c = Convert.ToInt32(Console.ReadLine());
            int product = Multiply(a, b, c);
            Console.WriteLine($"Product of three number is {product}");
        }
    }
}
