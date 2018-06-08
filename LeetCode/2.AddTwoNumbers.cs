using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //You are given two non-empty linked lists representing two non-negative integers.The digits are stored in reverse order and each of their nodes contain a single digit.Add the two numbers and return it as a linked list.
    //You may assume the two numbers do not contain any leading zero, except the number 0 itself.

    //Example

    //Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    //Output: 7 -> 0 -> 8
    //Explanation: 342 + 465 = 807.


    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }

    public partial class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode Result = new ListNode(0);

            ListNode Node1Cursor = l1;
            ListNode Node2Cursor = l2;

            ListNode Head = Result;
            bool NeedNextRun = true;
            while (NeedNextRun)
            {
                var Sum = Head.val + GetNodeValue(Node1Cursor) + GetNodeValue(Node2Cursor);

                Head.val = Sum % 10;

                if (Sum > 9)
                    Head.next = new ListNode(1);


                if (Node1Cursor != null)
                    Node1Cursor = Node1Cursor.next;

                if (Node2Cursor != null)
                    Node2Cursor = Node2Cursor.next;

                NeedNextRun = (Node1Cursor != null || Node2Cursor != null);

                if (NeedNextRun && Head.next == null)
                    Head.next = new ListNode(0);

                Head = Head.next;
            }

            return Result;
        }

        private int GetNodeValue(ListNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return node.val;
        }
    }
}
