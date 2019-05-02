using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_21
{
    class Program
    { //Sorting an Array using Bubble Sort
        static void Main(string[] args)
        {

            int[] number = { 1, 7, 4, 9, 2, 6, 8 };
         
            int temp;
            

            
            for (int i = 1; i <= number.Length - 1; i++)
            {
               
                for (int j = 0; j < number.Length-1; j++)
                {
                    if (number[j + 1] < number[j])
                    {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        
                    }
                }
            }

          
            foreach (int num in number)
            {
                Console.Write("\t {0}", num);
            }
            Console.Read();
        }
    }
    
}
