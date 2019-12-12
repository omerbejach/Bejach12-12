﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a Secret number and let a friend guess that number ;) ");
            Console.Write("Secret number  : ");
            int Secret = Convert.ToInt32(Console.ReadLine());
            Console.Write("Guessed number : ");
            int Guess = Convert.ToInt32(Console.ReadLine());
            int CountGuesses = 0;
            while (Secret != Guess)
            {
                if (Guess > Secret)
                {
                    Console.WriteLine("Too big...");
                    CountGuesses++;
                }
                else
                {
                    Console.WriteLine("Too small...");
                    CountGuesses++;
                }

                Console.Write("Guess again : ");
                Guess = Convert.ToInt32(Console.ReadLine());

            }

            CountGuesses++;
            Console.WriteLine("Bingo!");
            Console.WriteLine("You guessed ..." + CountGuesses + " times.");
            

        }
    }
}
