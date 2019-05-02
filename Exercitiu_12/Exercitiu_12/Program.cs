using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_12
{       //Write a function to count a total number of set bits in a 32-bit Integer?
    class Program
    {

        static public void Main()
        {
            Console.WriteLine("Enter integer:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of set bits - " + CountSetBits(n));
        }

        public static int CountSetBits(int n)
        {

            if (n == 0)
                return 0;

            else

                return (n & 1) + CountSetBits(n >> 1);
        }

    } 
        
}

