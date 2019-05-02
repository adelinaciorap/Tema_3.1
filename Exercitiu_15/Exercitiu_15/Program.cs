using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_15
{
    class Program
    { //C# program to check if a number is Armstrong number or not?
        // xy, if x3 + y3 = xy, then xy is an armstrong number. 
        static void Main(string[] args)
        {

            int val = 372, sum = 0;
            int rem;

            // check for armstrong
            for (int i = val; i > 0; i = i / 10)
            {
                rem = i % 10;
                sum = sum + rem * rem * rem;
            }

            if (sum == val)
            {
                Console.Write("Armstrong Number");
            }
            else
            {
                Console.Write("Not an Armstrong Number");
            }
            Console.ReadLine();
        }
    }
}
        
