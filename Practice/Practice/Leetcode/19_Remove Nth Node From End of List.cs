using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode
{
    class _19_Remove_Nth_Node_From_End_of_List
    {
        static void Main(String[] args)
        {
            ListNode list = new ListNode(1);
            list.next = new ListNode(2);
            list.next.next = new ListNode(3);
            list.next.next.next = new ListNode(4);
            list.next.next.next.next = new ListNode(5);
            _19_Remove_Nth_Node_From_End_of_List a = new _19_Remove_Nth_Node_From_End_of_List();

            ListNode  list2 = new ListNode(1);

            ListNode result = a.RemoveNthFromEnd(list2, 1);
        }
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            /*
            Steps: 
            1. Run thru the list and get count of the list.
            2. The node to delete is countOfList - n
            3. Delete that node
            */
            ListNode temp = head;
            int count = 0;
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            temp = dummy;
            int nodeToDelete = count - n;
            int x = 0;
            ListNode prev = null;
            //while (temp != null)
            //{

            //    if (x == nodeToDelete)
            //    {
            //        prev.next = temp.next;
            //        temp.next = null;
            //        temp = prev.next;
            //        break;
            //    }
            //    x++;
            //    prev = temp;
            //    temp = temp.next;
            //}
            //return dummy.next;
            while (nodeToDelete > 0)
            {
                nodeToDelete--;
                temp = temp.next;
            }
            temp.next = temp.next.next;
            return dummy.next;
        }
    }
}
