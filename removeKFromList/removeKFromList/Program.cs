using System;

namespace removeKFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 3, 1, 2, 3, 4, 5 };
            int k = 3;
            //int [] x 	= {3};
            //int k1 = 3;
            //int [] x2 = {1, 2, 3, 4, 5, 6, 7};
            //int k2 = 10; 
            //int [] x = {123, 456, 789, 0};
            //int k = 0;
            //int[] x = { 1000, 1000, 3, 1000 };
            //int k = 1000;

            ListNode<int> head = new ListNode<int>();
            //ListNode end = new ListNode();

            for (int i = 0; i < x.Length; i++)
            {
                if (i == 0)
                {
                    // System.out.println("Here 1...");
                    head.SetValue(x[i]);
                    //  System.out.println("Here 2...");
                    if (i == x.Length - 1)
                    {
                        head.next = null;
                        Console.WriteLine("Here 3...");
                        break;
                    }
                    continue;
                }
                ListNode<int> end = new ListNode<int>(x[i]);
                ListNode<int> n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = end;
            }

            /*
            for (Integer element : llist)
            {
              System.out.println(element);	
            }
            */
            Console.WriteLine("linklist before: " + head.PrintForward());
            ListNode<int> top = removeKFromList(head, k);
            Console.WriteLine("linklist after: " + top.PrintForward());
            Console.WriteLine("Ended...");
        }

        public static ListNode<int> removeKFromList(ListNode<int> l, int k)
        {
            if (l == null)
                return l;
            
            // Handles scenerio when head node (first node) value = k
            while (l.value == k)
            {
                if (l.next == null)
                {
                    return (l = null);
                }
                else l = l.next;   // New head node
            }

            ListNode<int> n = l;
            //System.out.println("1n.value=" + n.value + " n.next=" + n.next);
            while (n.next != null)
            {
                if (n.next.value == k)
                {   //System.out.println("2n.value=" + n.value + " n.next=" + n.next);
                    n.next = n.next.next;
                    //System.out.println("3n.value=" + n.value + " n.next=" + n.next);
                    continue;
                }
                //System.out.println("4n.value=" + n.value + " n.next=" + n.next);
                n = n.next;
                //System.out.println("5n.value=" + n.value + " n.next=" + n.next);
            }
            //System.out.println("head=" + head.value); 
            return l;
        }
    }
}
