using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _234_Palindrome_Linked_List
    {
        public static void Main(String[] args)
        {
            string s = "kushal";
            s = s.Replace(" ", "");
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            _234_Palindrome_Linked_List a = new _234_Palindrome_Linked_List();
            bool result = a.IsPalindrome(head);
            a.Reverse(head);
        }
        public bool IsPalindrome(ListNode head)
        {
            return false;
        }
        public void Reverse(ListNode head)
        {
            /* 
             * 1>2>2
             * head
             * next
             * */

            ListNode curr = head;
            ListNode prev = null;
            ListNode next = head;
            while(curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
        }
    } 

    //public class ListNode
    //{
    //    public int val;
    //    ListNode next;
    //    public ListNode(int x) { val = x; }
    //}
}
