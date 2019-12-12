using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two numbers :");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for ( int i = 1; i <= b; i++ )
            {
                sum = sum + a;
            }
            Console.WriteLine(sum);
        }
    }
}
