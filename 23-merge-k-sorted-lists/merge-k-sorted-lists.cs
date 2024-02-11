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
            var pq = new PriorityQueue<ListNode, int>(); // min queue
            // min heap
            foreach (var list in lists)
            {
                if (list!=null) // put first node for each linked list
                {
                    pq.Enqueue(list, list.val);
                }
            }

            //Console.WriteLine(pq.Count);
            var newLinkedList = new ListNode(); // head of new linked list
            var currentl = newLinkedList;
            while (pq.Count>0)
            {
                var el = pq.Dequeue();
                var newi = new ListNode(el.val);
                currentl.next = newi;
                currentl = newi;
                if(el.next!=null)
                {
                   pq.Enqueue(el.next, el.next.val);
                }
            }

            return newLinkedList.next;
        }
    }