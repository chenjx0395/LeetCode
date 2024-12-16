using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] a = { 'a', 'b', 'c' };
            int[] b= { 1, 2, 3 };
            Console.WriteLine(b);
            Case1();
        }

        public static void Case1()
        {
            var myLinked = new MyLinkedListCase();
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
