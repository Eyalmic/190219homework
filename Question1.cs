using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Please enter a set of two numbers to determine if they can be divided without remainder");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if(a%b==0)
            {
                Console.WriteLine("These numbers can be divided, the answer is:" + a / b);
            }
            else
            {
                Console.WriteLine("These numbers leave a remainder");
            }
        }
    }
}
