/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
    public class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            var pq = new PriorityQueue<ListNode, int>();
            // min heap
            foreach (var list in lists)
            {
                var current = list;
                while (current!=null)
                {
                    var newi = new ListNode(current.val);
                    pq.Enqueue(newi, current.val);
                    current = current.next;
                }
            }

            Console.WriteLine(pq.Count);
            var newLinkedList = new ListNode();
            var currentl = newLinkedList;
            while (pq.Count>0)
            {
                var el = pq.Dequeue();
                currentl.next = el;
                currentl = currentl.next;
            }

            return newLinkedList.next;
        }
    }