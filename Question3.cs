using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int a = Convert.ToInt32(Console.ReadLine());
            while (a >= 0)
            {
                sum = sum + a;
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sum);

        }
    }
}
