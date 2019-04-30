using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_3
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Enter a Number to find factorial: ");

            int n = Convert.ToInt32(Console.ReadLine());

            int r = Fact(n);

            Console.WriteLine("{0}! = {1}", n, r);



            Console.Write("Enter a Number to find factorial: ");

            n = Convert.ToInt32(Console.ReadLine());

            r = Factorial(n);

            Console.WriteLine("{0}! = {1}", n, r);

        }

        static int Fact(int n)

        {

            if (n <= 1)

                return 1;

            return n * Fact(n - 1);

        }
        

        static int Factorial(int n)

        {
            if (n <= 1)

                return 1;

            int result = 1;

            for (int i = 2; i <= n; i++)

            {
                result = result * i;
            }
            return result;

        }

    }

}

