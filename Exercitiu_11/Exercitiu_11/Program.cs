using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_11
{ //Write a function to print the nth number in Fibonacci series?
    // F0=0, F1=1, Fn = Fn-1 + Fn-2
    

    class Program
    {
        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }

       
        public static void Main(string[] args)
        {
            int n = 15;
            Console.Write(Fib(n));
            Console.ReadKey();
        }
    }
}

