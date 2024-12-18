using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListCode
{
    internal class SwapPairsCase
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode font = null, last = head;
            if (head.next != null) head = head.next;
            while (last?.next != null)
            {
                var next = last.next;
                var temp = next.next;
                if (font != null) font.next = next;
                font = last;
                next.next = last;
                last.next = temp;
                last = temp;

            }
            return head;
        }
    }
}
