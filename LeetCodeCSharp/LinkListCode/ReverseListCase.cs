using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListCode
{

   
   

    public class ReverseListCase
    {
        public static ListNode ReverseList(ListNode head)
        {
            ListNode last = null , now = head , next;
            while (now != null) { 
                next = now.next;
                now.next = last;
                last = now;
                now = next;
            }
            return last ; 
        }
    }
}
