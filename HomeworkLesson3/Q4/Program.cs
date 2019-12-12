using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number :");
            int a = Convert.ToInt32(Console.ReadLine());
            int m = 1;
            do
            {
                m++;

            } while (a % m != 0 && m < a);
            if (m < a)
            {
                Console.WriteLine("Not a prime number");
            }
            else
            {
                Console.WriteLine("Prime number");
            };
        }
    }
}
