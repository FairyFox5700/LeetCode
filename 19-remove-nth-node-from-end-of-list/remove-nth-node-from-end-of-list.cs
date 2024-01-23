    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
           
            if (head == null) 
            {
                return null;
            }
            var current = head;
            while (current.next != null && n>0)
            {
                current = current.next;
                n--;
            }
           
            if(n>0 && current.next == null) // reached to the end already
            // then only option to remove the item form the list begining
            {
                return head.next;
            }

            // if no we move with a gap of n , untill the end of the list
            var nodeToRemove = head;
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