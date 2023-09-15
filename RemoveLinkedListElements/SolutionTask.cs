using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveLinkedListElements
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


    public class SolutionTask
    {
        // Runtime 94ms Beats 38.28%
        // Memory 42.65MB Beats 12.82%
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null) return null;

            if (head.next != null)
            {
                head.next = RemoveElements(head.next, val);
            }

            if (head.val == val)
            {
                return head.next ?? null;
            }

            return head;
        }

        // Runtime 77ms Beats 95.05% 
        // Memory 42.31MB Beats 31.50%
        public ListNode RemoveElements2(ListNode head, int val)
        {
            if (head == null) return null;

            ListNode startNode = head;
            ListNode node = head;
            ListNode prevNode = null;

            while (node != null)
            {
                if (node.val == val)
                {
                    if (prevNode == null)
                    {
                        node = node.next;
                        startNode = node;
                        continue;
                    }

                    prevNode.next = node.next;
                    node = node.next;
                    continue;
                }
                
                prevNode = node;
                node = node.next;
            }

            return startNode;
        }

    }
}
