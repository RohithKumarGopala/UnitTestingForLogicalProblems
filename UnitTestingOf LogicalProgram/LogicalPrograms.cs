using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingOf_LogicalProgram
{
    public class LogicalPrograms
    {
        public int FibonacciSeries(int number)
        {
            int a = 0, b = 1, c = 0;

            Console.Write("The Fibonacci series is : " + a + " " + b);

            for (int i = 2; i < number; i++)
            {
                c = a + b;
                Console.Write(" " + c);
                a = b;
                b = c;
            }
            return c;
        }

        
        public bool PerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == number)
            {
                Console.WriteLine(number + " is a perfect number");
                return true;
            }
            else
            {
                Console.WriteLine(number + " is NOT a perfect number");
                return false;
            }
        }

        
        public bool PrimeNumber(int number)
        {
            bool isPrime = true;

            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine(number + " is a Prime number");
                return true;
            }
            else
            {
                Console.WriteLine(number + " is not a Prime number");
                return false;
            }
        }

        
        public int ReverseNumber(int number)
        {
            Console.WriteLine("The original number is " + number);

            int reverse = 0;
            while (number != 0)
            {
                int remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }
            Console.WriteLine("The reversed number is " + reverse);
            return reverse;
        }

    }
}
