using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an unsorted array which has a number in the majority (a number appears more than 50% in the array), find that number?

            int[] x = { 1, 2, 3, 4, 5, 2, 2, 2, 2 };
            int maj = 0;
            int number, count;
            number = count = 0;
            for (int i = 0; i <= x.Length; i++)
            {
                for (int j = i; j < x.Length; j++)
                {
                    if (x[i] == x[j])
                    {
                        count++;
                    }
                }
                if (count > x.Length / 2)
                {
                    maj= count;
                    number = x[i];
                    count = 0;
                }
                count = 0;
            }
            Console.WriteLine("No. " + number + " comes " + maj + " times");
        }
    }

}



    

