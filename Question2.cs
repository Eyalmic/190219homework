using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 Numbers to calculate Sum and Average");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            double avg = sum / 2.0;
            Console.WriteLine("Sum is:" + sum);
            Console.WriteLine("Average is:" + avg);



        }
    }
}
