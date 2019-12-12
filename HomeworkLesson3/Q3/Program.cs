using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number until it's negative : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (a >= 0)
            {
                sum = sum + a;
                Console.Write("Enter another number : ");
                a = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The sum of these numbers is : " + sum);

        }
    }
}
