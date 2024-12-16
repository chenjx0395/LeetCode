using System.ComponentModel;
using System.Reflection;

namespace LinkListCode
{
    // 单向链表结构的实现
    public class MyLinkedList
    {
        private int _length = 0; // 显式初始化
        private Node _head;

        private class Node
        {
            public int Val;
            public Node Next;

            public Node(int val, Node next)
            {
                this.Val = val;
                this.Next = next;
            }
        }

        private void Init(int val)
        {
            _head = new Node(val, null);
            _length++;
        }

        // 返回指定索引值
        public int Get(int index)
        {
            if (!CheckIndexForAccess(index)) return -1;

            var p = _head;
            for (var i = 0; i < index; i++)
            {
                p = p.Next;
            }

            return p.Val;
        }

        // 头插值
        public void AddAtHead(int val)
        {
            AddAtIndex(0, val);
        }

        // 尾插值
        public void AddAtTail(int val)
        {
            AddAtIndex(_length, val);
        }

        // 插入到目标索引前
        public void AddAtIndex(int index, int val)
        {
            if (!CheckIndexForInsert(index)) return;

            if (_length == 0)
            {
                Init(val);
                return;
            }

            var p = _head;
            Node lP = null;
            for (var i = 0; i < index; i++)
            {
                lP = p;
                p = p.Next;
            }

            var newNode = new Node(val, p);
            if (index == 0)
            {
                _head = newNode;
            }
            else
            {
                lP.Next = newNode;
            }
            _length++;
        }

        // 删除索引位置的节点
        public void DeleteAtIndex(int index)
        {
            if (!CheckIndexForAccess(index)) return;

            var p = _head;
            Node lP = null;
            for (var i = 0; i < index; i++)
            {
                lP = p;
                p = p.Next;
            }

            if (index == 0)
            {
                _head = p.Next;
            }
            else
            {
                lP.Next = p.Next;
                p.Next = null;
            }
            _length--;
        }

        // 校验访问索引
        private bool CheckIndexForAccess(int index)
        {
            return index >= 0 && index < _length;
        }

        // 校验插入索引
        private bool CheckIndexForInsert(int index)
        {
            return index >= 0 && index <= _length;
        }
    }

}