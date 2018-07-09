using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _61_Rotate_List
    {
        static void Main(String[] args)
        {
            ListNode list = new ListNode(1);
            ListNode head = list;
            for (int i = 0; i <= 5; i++)
            {
                list.next = new ListNode(i);
                list = list.next;

            }

            ListNode final = RotateRight(list, 2);
        }
        public static ListNode RotateRight(ListNode head, int k)
        {
            if (getLength(head) != 0)
                k = k % getLength(head);
            for (int i = 0; i < k; i++)
                head = rotate(head);
            return head;
        }
        private static ListNode rotate(ListNode head)
        {
            ListNode curr = head;
            ListNode secondLast = null;
            if (curr == null)
                return null;
            while (curr.next != null)
            {
                secondLast = curr;
                curr = curr.next;
            }
            curr.next = head;
            head = curr;
            if (secondLast != null)
                secondLast.next = null;
            return head;
        }

        private static int getLength(ListNode head)
        {
            ListNode curr = head;
            int len = 0;
            if (head == null)
                return 0;
            else
            {
                while (curr.next != null)
                {
                    curr = curr.next;
                    len++;
                }
                return len;
            }
        }
    }

       class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }
}
