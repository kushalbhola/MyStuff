using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode
{
    class _21_MergeTwoSortedList
    {
        static void Main(String[] args)
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);

            _21_MergeTwoSortedList a = new _21_MergeTwoSortedList();
            ListNode result = a.MergeTwoLists(l1, l2);
        }
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;
            if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }

            else
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }

        }
        public int getCount(ListNode l)
        {
            ListNode curr = l;
            int result = 0;
            while (curr != null)
            {
                result++;
                curr = curr.next;
            }
                
            return result;
        }
    }

     //public class ListNode {
     //    public int val;
     //    public ListNode next;
     //    public ListNode(int x) { val = x; }
     //}
 
}
