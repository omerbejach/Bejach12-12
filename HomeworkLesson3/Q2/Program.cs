using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleasde input two numbers :");
            Console.Write("First number : ");
            int a = Convert.ToInt32(Console.ReadLine() );
            Console.Write("Second number : ");
            int b = Convert.ToInt32(Console.ReadLine() );
            int sum = a + b;
            double avg = sum / 2.0;
            Console.WriteLine("The total of both numbers is : " + sum );
            Console.WriteLine("The average of both numbers is : " + avg);
        }
    }
}
