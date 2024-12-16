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
                //前置哨兵
                ListNode frontPoint = null;
                switch (frontPoint)
                {

                }

                var point = head;
                while (point != null)
                {
                    if (point.val == val)
                    {
                        // 头节点
                        if (frontPoint == null)
                        {
                            head = point.next;
                            point.next = null;
                            point = head;
                        }
                        else
                        {
                            frontPoint.next = point.next;
                            point.next = null;
                            point = frontPoint.next;

                        }
                    }
                    else
                    {
                        // 前移
                        frontPoint = point;
                        point = point.next;
                    }

                }
                return head;
            }
        }
    }
}