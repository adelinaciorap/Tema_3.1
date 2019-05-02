using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a Program which checks if two Strings are Anagram or not?
            
            Console.Write("Enter first word:");
            string word1 = Console.ReadLine();
            Console.Write("Enter second word:");
            string word2 = Console.ReadLine();
            
            
            char[] char1 = word1.ToCharArray();
            char[] char2 = word2.ToCharArray();
            
            Array.Sort(char1);
            Array.Sort(char2);

              
            string NewWord1 = new string(char1);
            string NewWord2 = new string(char2);

           
            if (NewWord1 == NewWord2)
            {
                Console.WriteLine(" Words \"{0}\" and \"{1}\" are anagrams", word1, word2);
            }
            else
            {
                Console.WriteLine(" Words \"{0}\" and \"{1}\" are not anagrams", word1, word2);
            }

             
            Console.ReadLine();
        }
           
        
    }
}
