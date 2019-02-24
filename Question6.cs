using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1;
            int i = 1;
            int a = Convert.ToInt32(Console.ReadLine());
            while (i<=a)
            {
                sum = sum * i;
                i++;
            }
            Console.WriteLine("Assembly Value:" + sum);
        }
    }
}
