using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //How to find all pairs of elements in an integer array, whose sum is equal to a given number?

            int[] arr = new int[] { 10, 4, 9, 0, 1 ,6};
            Console.WriteLine("Enter number for sum");
            int total = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pair of elements whose sum is: " + total);

            for (int i = 0; i < arr.Length; i++)
            {
                
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    
                    if (arr[i] + arr[j] == total)
                       
                    {
                        Console.WriteLine($"{arr[i]}, {arr[j]}");
                    }

                }
            }
        }
    }
}
