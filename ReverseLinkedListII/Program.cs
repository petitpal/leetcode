using System;
using System.Collections;
using System.Collections.Generic;

namespace ReverseLinkedListII
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new ListNode(1, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(5, new ListNode(6,null))))));

            Console.Write("Original: ");
            var nextNode = node;
            while (nextNode != null)
            {
                Console.Write($"{nextNode.val}>");
                nextNode = nextNode.next;
            }
            Console.WriteLine("\n");

            var solution = new Solution();
            var output = solution.ReverseBetween(node, 4, 2);

            Console.Write("Reserved: ");
            while (output != null)
            {
                Console.Write($"{output.val}>");
                output = output.next;
            }
            Console.WriteLine("\n");

        }
    }

    
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }


    public class Solution {

        public ListNode ReverseBetween(ListNode head, int left, int right) {

            var l = new List<ListNode>();
            int insertPoint = -1;

            ListNode current = head;
            ListNode next;

            while (current != null) {
                next = current.next;

                if (current.val<=left && current.val>=right)
                {
                    if (insertPoint == -1) insertPoint = l.Count;
                    l.Insert(insertPoint, current);
                }
                else
                {
                    l.Add(current);
                }

                current = next;
            }

            for (var index=0; index<l.Count; index++)
            {
                if (index < l.Count-2)
                {
                    l[index].next = l[index+1];
                }
            }

            return head;
        }

    }
}
