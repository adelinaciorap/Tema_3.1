using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_20
{
    class Program
    { //Sorting an Array using Selection Sort
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 3, 6, 7, 8, 9, 11, 12 };
            
            int pos_min, temp;

            for (int i = 0; i < arr.Length-1; i++)
            {
                pos_min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[pos_min])
                    {
                        
                        pos_min = j;
                    }
                }

                
                if (pos_min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[pos_min];
                    arr[pos_min] = temp;
                }
            }
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n\n");
        }
    }
    }

