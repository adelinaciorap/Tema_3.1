using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_6
{
    class Program
    {
        static void Main(string[] args)
        {//How to find sum of digits of a number using Recursion?

            Console.WriteLine("Enter your number");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = SumOfDigits(number);
            Console.WriteLine("Sum of Digits in {0} = {1}", number, sum);
            Console.ReadLine();
           

        }

        private static int SumOfDigits(int val)
        {
            if (val != 0)
            {
                return (val % 10 + SumOfDigits(val / 10));
            }
            else
            {
                return 0;
            }
        }
    }
}
