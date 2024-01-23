    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var current = head;
            if (current.next == null) // if there is only one node in the list
            {
                return null;
            }
            // head = [1,2], n = 2
            while (current.next != null && n>0)
            {
                current = current.next;
                n--;
            }
            var nodeToRemove = head;
            if(n>0 && current.next == null)
            {
                return head.next;
            }
            while (current.next!=null)// until the end of list
            {
                nodeToRemove= nodeToRemove.next;
                current = current.next;
            }

            // now nodeToRemove is the node to remove

            nodeToRemove.next = nodeToRemove.next.next;
            // edge cases
           // head = [1], n = 1
            return head;

        }
    }