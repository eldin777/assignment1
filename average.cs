using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class average
    {
        public void sumAverage(int[] arr, int size)
        {

            int sum = 0;
            int average = 0;
            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            average = sum / size;
            Console.WriteLine("Sum Of array is = " + sum);
            Console.WriteLine("Average Of array is = " + average);
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the Size of the array  =");
            size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the Elements of the array = ");
            for (int i = 0; i < size; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int len = a.Length;
            average avg = new average();
            avg.sumAverage(a, len);
        }
    }
}
