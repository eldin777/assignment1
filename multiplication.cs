using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class multiplication
    {
        public static void Main()
        {
            int a, b, c,mult;
            Console.Write("First number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third number");
            c = Convert.ToInt32(Console.ReadLine());
            mult = a * b * c;
            Console.WriteLine("Product of three number" + mult);
        }
    }
}
