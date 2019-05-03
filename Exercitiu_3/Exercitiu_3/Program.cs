using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_3
{
    class Program
    {
        const int _max = 100000;
        static void Main(string[] args)
            
        {

            Console.Write("Enter a Number to find factorial: ");

            double n = Convert.ToInt32(Console.ReadLine());

            double r = Fact(n);

            Console.WriteLine("{0}! = {1}", n, r);



            Console.Write("Enter a Number to find factorial: ");

            n = Convert.ToInt32(Console.ReadLine());

            r = Factorial(n);

            Console.WriteLine("{0}! = {1}", n, r);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Fact(n);
            sw.Stop();
            Console.WriteLine("Time Taken Recursive-->{0}", ((double)(sw.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
           
            sw.Start();
            Factorial(n);
            sw.Stop();
            Console.WriteLine("Time Taken Iterative-->{0}", ((double)(sw.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        }

        static double Fact(double n)

        {

            if (n <= 1)

                return 1;

            return n * Fact(n - 1);

        }
        

        static double Factorial(double n)

        {
            if (n <= 1)

                return 1;

            double result = 1;

            for (int i = 2; i <= n; i++)

            {
                result = result * i;
            }
            return result;

        }

    }

}

