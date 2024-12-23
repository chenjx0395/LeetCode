using System.Collections.Generic;

namespace LinkListCode
{
    public class DetectCycleCase
    {
        // 暴力法
        public ListNode DetectCycle1(ListNode head)
        {
            var storage = new List<ListNode>();
            var temp = head;
            while (temp != null)
            {
                // 判断列表中是否存在当前节点
                if (storage.Contains(temp))
                    return temp;
                storage.Add(temp);
                temp = temp.next;
            }

            return null;
        }

        // 快慢指针
        public ListNode DetectCycle(ListNode head)
        {
            ListNode quick = head, slow = head;
            // 找出相遇点
            while (quick?.next != null)
            {
                slow = slow.next;
                quick = quick.next.next;
                // 代表存在坏
                if (quick != slow) continue;
                // 二个指针一起走，直到相遇
                slow = head;
                while (slow != quick)
                {
                    slow = slow.next;
                    quick = quick.next;
                }
                return slow;
            }
            return null;
        }
    }
}