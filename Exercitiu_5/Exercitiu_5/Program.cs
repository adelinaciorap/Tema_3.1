using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_5
{
    class Program
    {
        static void Main(string[] args)
        {//How to remove duplicates from a sorted linked list?\
            LinkedList<int> newlist = new LinkedList<int>();

            LinkedListNode<int> firstnode = new LinkedListNode<int>(10); 

            newlist.AddFirst(firstnode); 

            LinkedListNode<int> node2 = new LinkedListNode<int>(20);

            newlist.AddAfter(firstnode, node2);
        }
    }
}
