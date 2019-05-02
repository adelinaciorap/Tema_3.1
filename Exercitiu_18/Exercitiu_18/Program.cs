using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_18
{
    class Program
    { //Write code to reverse a linked list, if you able to do it using loops, try to solve with recursion?
        static void Main(string[] args)
        {
            LinkItem item = generateLinkList(5);
            printLinkList(item);
            Console.WriteLine("Reversing the list ...");
            LinkItem newItem = reverseLinkList(item);
            printLinkList(newItem);
            Console.ReadLine();
        }

       private static LinkItem generateLinkList(int total)
        {
            LinkItem item = new LinkItem();
            for (int number = total; number >= 1; number--)
            {
                item = new LinkItem
                {
                    name = string.Format("I am the link item number {0}.", number),
                    next = (number == total) ? null : item
                };
            }
            return item;
        }

        static public void printLinkList(LinkItem item)
        {
            while (item != null)
            {
                Console.WriteLine(item.name);
                item = item.next;
            }
        }

        private static LinkItem reverseLinkList(LinkItem item)
        {
            LinkItem newItem = new LinkItem
            {
                name = item.name,
                next = null
            };

            while (item.next != null)
            {
                newItem = new LinkItem
                {
                    name = item.next.name,
                    next = newItem
                };

                item = item.next;
            }

            return newItem;
        }
    }

    class LinkItem
    {
        public string name;
        public LinkItem next;
    }

} 


