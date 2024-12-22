using System.Collections;

namespace LinkListCode
{
    public class RemoveNthFromEndCase
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            // 扫描获取链表长度
            var length = 0;
            ListNode target = head, temp = head;
            while (temp != null)
            {
                length++;
                temp = temp.next;
            }

            var count = 0;
            if (n == length)
            {
                head = head.next;
            }
            else
            {
                while (count < length - n - 1)
                {
                    target = target.next;
                    count++;
                }
                temp = target.next;
                target.next = temp.next;
                temp.next = null;
            }
            return head;
        }
    }
}