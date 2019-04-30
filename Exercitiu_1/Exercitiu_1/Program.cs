using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an array of ints, write a C# method to total all the values that are even number.


            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(SumaNumerelor( array));

        }

        private static int SumaNumerelor(int[] array)
        {

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] % 2 == 0)
                {
                    sum = sum + array[i];
                }

            }
            return sum;
        }
    }
    
}
