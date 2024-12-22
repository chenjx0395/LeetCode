namespace LinkListCode
{
    public class GetIntersectionNodeCase
    {
        // 暴力法
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var tempA = headA;
            while (tempA != null)
            {
                var tempB = headB;
                while (tempB != null)
                {
                    if (tempA == tempB)
                        return tempA;
                    tempB = tempB.next;
                }

                tempA = tempA.next;
            }

            return null;
        }

        // 测长规律法
        public static ListNode GetIntersectionNode2(ListNode headA, ListNode headB)
        {
            ListNode tempA = headA, tempB = headB;
            int lengthA = 0, lengthB = 0;
            // 判断A的长度
            while (tempA != null)
            {
                tempA = tempA.next;
                lengthA++;
            }

            // 判断B的长度
            while (tempB != null)
            {
                tempB = tempB.next;
                lengthB++;
            }

            tempA = headA;
            tempB = headB;
            // AB等长，同步移动可得解
            if (lengthA == lengthB)
            {
                if (Move(out var listNode)) return listNode;
            }
            else if (lengthA > lengthB)
            {
                // A比B长，A先移动到区间长度差，然后同步移动
                while (lengthA > lengthB)
                {
                    tempA = tempA.next;
                    lengthA--;
                }

                if (Move(out var listNode)) return listNode;
            }
            else
            {
                // B比A长，B先移动到区间长度差，然后同步移动
                while (lengthB > lengthA && tempB != null)
                {
                    tempB = tempB.next;
                    lengthB--;
                }

                if (Move(out var listNode)) return listNode;
            }

            return null;

            bool Move(out ListNode listNode)
            {
                while (tempA != null)
                {
                    if (tempA == tempB)
                    {
                        listNode = tempA;
                        return true;
                    }

                    tempA = tempA.next;
                    tempB = tempB.next;
                }

                listNode = null;
                return false;
            }
        }
    }
}