using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_9
{
    class Program
    {
        static void Main(string[] args)

        //How to merge two sorted linked list.
        {
            LinkedList<int> ll1 = new LinkedList<int>();
            LinkedList<int> ll2 = new LinkedList<int>();

            Random rng = new Random();
            for (int i = 0; i <= 10; i++)
            {
                ll1.AddLast(rng.Next(1, 100));
                ll2.AddLast(rng.Next(1, 100));
            }
            foreach (var a in ll1) Console.Write(a + " ");
            Console.WriteLine();
            foreach (var a in ll2) Console.Write(a + " ");
            Console.WriteLine();
            ll1 = new LinkedList<int>(ll1.Union(ll2).OrderBy(x => x));
            foreach (var a in ll1) Console.Write(a + " ");

        }

        
    }
    
}
