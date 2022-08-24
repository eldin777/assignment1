using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class functionmultiplication
    {
            public static void multiply(int a, int b, int c, out int mult)
            {
                mult = a * b * c;
            }
            public static void Main()
            {
                int a, b, c, mult;
                Console.Write("First number");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Second number");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Third number");
                c = Convert.ToInt32(Console.ReadLine());
                multiply(a, b, c, out mult);
                Console.WriteLine($"Product of three number is {mult}");
            }
        
    }
}
