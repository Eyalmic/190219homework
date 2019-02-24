using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 0;
            Console.WriteLine("Enter two numbers to Multiply:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            
            while (i<b)
            {
                sum = sum + a;
                i++;
            }
            Console.WriteLine("Sum:" + sum);

        }
    }
}
