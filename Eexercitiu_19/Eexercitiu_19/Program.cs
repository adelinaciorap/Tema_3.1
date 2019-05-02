using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eexercitiu_19
{
    class Program
    { //How to rotate an array by a given pivot?
        static void Main(string[] args)
        {
            int[] x = { 1, 5, 8, 6, 7, 2, 9, 10, 12 };
            int[] y = new int[x.Length];
            int pivot = 2;
            int k = 0;
            for (int i = pivot; i < x.Length; i++)
            {
                y[k] = x[i];
                k++;
            }
            for (int j = 0; j < pivot; j++)
            {
                y[k] = x[j];
                k++;
            }
            foreach (int z in y)
            {
                Console.WriteLine(z);
            }
            
        }
    }
}