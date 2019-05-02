using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_13
{  
      // Write a function to remove duplicate characters from String?

    class Program
    {
        public static void Main(string[] args)
        {
            string value1 = RemoveDuplicateChars("Un text de test");
           
            Console.WriteLine(value1);
           
        }

        static string RemoveDuplicateChars(string key)
        {

            string table = "";
            
            string result = "";

            // Loop over each character.
            foreach (char value in key)
            {
                // See if character is in the table.
                if (table.IndexOf(value) == -1)
                {
                    // Append to the table and the result.
                    table += value;
                    result += value;
                }
            }
            return result;
        }


    }


}
