using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Hello ");
            Console.WriteLine(name);

            Console.WriteLine("Please input two numbers :");
            Console.WriteLine("Do they divide without modulo?");
            Console.Write("Your first number : ");
            int a = Convert.ToInt32(Console.ReadLine() );
            Console.Write("Your second number : "); 
            int b = Convert.ToInt32(Console.ReadLine() );
            if (a % b == 0 )
            {
                Console.WriteLine("Devides without modulo");
            }
            else
            {
                Console.WriteLine("Devides with modulo");
            }
        }
    }
}
