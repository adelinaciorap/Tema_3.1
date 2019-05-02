using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_16
{
    class Program
    { //Algorithm to check if a number is Prime or not?
        static void Main(string[] args)
        {
            Console.WriteLine("Your number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            } if (count == 2)
            {
                Console.WriteLine("{0} is a Prime Number", number);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();
        }
        
    }
}
