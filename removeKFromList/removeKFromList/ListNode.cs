using System;

namespace removeKFromList
{
    class ListNode<T>
    {
        public int value;
        public ListNode<T> next;

        public ListNode(int v, ListNode<T> n)
        {
            SetValue(v);
            SetNext(n);
        }
        public ListNode()
        {
        }
        public ListNode(int v)
        {
            SetValue(v);
        }
        public ListNode<T> GetNext()
        {
            return next;

        }
        public int GetValue()
        {
            return value;

        }
        public void SetNext(ListNode<T> n)
        {
            next = n;

        }
        public void SetValue(int v)
        {
            value = v;
        }
        public String PrintForward()
        {
            if (next != null)
            {
                return value + " -> " + next.PrintForward();
            }
            else
            {
                return value + "";
            }
        }
    }
}
