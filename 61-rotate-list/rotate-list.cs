    public class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if(head == null)
                return null;
            if(k==0)
                return head;
            var lastEl = head;
            // [1,2]
            var count = 0;
            while (lastEl.next!= null)
            {
                lastEl = lastEl.next;
                count++;
            }
           
            lastEl.next = head; // connected to cycle

            var current = head;
            var skip = count-(k%(count+1));
            while ((skip)>0)
            {
                current = current.next;
                skip--;
            }
            var newHead = current?.next;
            current.next = null; // mark the end of the list

            return newHead;
        }
    }