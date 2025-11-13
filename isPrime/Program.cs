using System;
using System.Collections;
using System.Globalization;

namespace program
{
    class firstProject
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Given number is a prime number");
            }
            else
            {
                Console.WriteLine("Given number is not a prime number");
            }
        }
    }

}

