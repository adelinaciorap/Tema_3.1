using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_5
{
    class Program
    {

        //How to remove duplicates from a sorted linked list?\

        public static LinkedList<int> InitializareLista()
        {
            LinkedList<int> list = new LinkedList<int>();

            LinkedListNode<int> firstNode = list.AddFirst(10);
            list.AddAfter(firstNode, 10);
            list.AddLast(20);
            list.AddLast(20);
            list.AddLast(50);
            return list;
        }

        public static void DisplayList(LinkedList<int> list)
        {
            foreach (var node in list)
                Console.Write(node + " ");
        }

        public static void RemoveDuplicates(LinkedList<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
                while (list.ElementAt(i) == list.ElementAt(i + 1))
                    list.Remove(list.ElementAt(i));

        }

        static void Main(string[] args)
        {
            LinkedList<int> list = InitializareLista();
            DisplayList(list);
            Console.WriteLine();
            RemoveDuplicates(list);
            DisplayList(list);
            Console.ReadKey();
        }


} 
    }

