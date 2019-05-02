using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_17
{
    class Program
    {  //Algorithm to check if a number is a Palindrome?
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer:");
            int input = Convert.ToInt32(Console.ReadLine());
           
            int reversed = 0;
            int digit;
            int temp = input;
            while (input >0)
            {
                digit = input % 10;
                reversed = reversed * 10 + digit;
                input =input / 10;
            }
            if (temp == reversed)
            {
                Console.WriteLine("is palindrome");
            }
            else
            {
                Console.WriteLine(" is  not palindrome");
            }
    }
        }
}
