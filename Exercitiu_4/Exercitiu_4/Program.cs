using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_4
{
    class Program
    {
        static void Main(string[] args)

        { //Algorithm to find if Array contains duplicates?
            
             bool ContainsDuplicatesnum = ContainsDuplicates(new int[] { 2, 4, 5, 4, 7, 1 });
                if (ContainsDuplicatesnum)
                {
                    Console.WriteLine("Array has Duplicates");
                }
                else
                {
                    Console.WriteLine("Array has no duplicates.");
                }
            

           
        }
        public static bool ContainsDuplicates(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j]) return true;
                }
            }
            return false;
        }


    }


}
       

