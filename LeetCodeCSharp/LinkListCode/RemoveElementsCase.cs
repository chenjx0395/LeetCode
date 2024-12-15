namespace LinkListCode
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class RemoveElementsCase
    {
        public class Solution
        {
            public static ListNode RemoveElements(ListNode head, int val)
            {
                // 找到不是val值的头
                while (head.next != null)
                {
                    if (head.val != val)
                    {
                        break;
                    }

                    var temp = head;
                    head = head.next;
                    temp.next = null;
                }
                var point = head;
                while (point?.next != null)
                {
  
                    if (point.next.val == val)
                    {
                        var temp = point.next;
                        point.next = temp.next;
                        temp.next = null;
                    }
                    point = point.next;

                }
                return head;
            }
        }
    }
}