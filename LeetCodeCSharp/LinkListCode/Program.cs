using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace LinkListCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char[] a = { 'a', 'b', 'c' };
            //int[] b = { 1, 2, 3 };
            //Console.WriteLine(b);
            // Case1();
            // Case2();
            // Case3();
            Case4();
        }

        public static void Case4()
        {
            // ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, null))));
            var head = new ListNode(1,null);
            var newHead = RemoveNthFromEndCase.RemoveNthFromEnd(head, 1);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(newHead.val);
                newHead = newHead.next;
            }
        }

        public static void Case3()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, null))));

            var newHead = new SwapPairsCase().SwapPairs(head);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(newHead.val);
                newHead = newHead.next;
            }
        }

        static void Case2()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            var newHead = ReverseListCase.ReverseList(head);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(newHead.val);
                newHead = newHead.next;
            }
        }


        public static void Case1()
        {
            var myLinked = new MyLinkedList();
            myLinked.AddAtHead(1);
            myLinked.AddAtTail(3);
            myLinked.AddAtIndex(1, 2);
            Console.WriteLine(myLinked.Get(1));
            myLinked.DeleteAtIndex(1);
            Console.WriteLine(myLinked.Get(1));
            ;
        }
    }
}
