public class Solution
    {
        // top-down approach
   public ListNode SortList(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        var mid = GetMiddle(head);
        var rightHead = mid.next;
        mid.next = null; // Split the list into two halves

        var left = SortList(head);
        var right = SortList(rightHead);
        return MergeTwo(left, right);
    }

        private ListNode MergeTwo(ListNode left, ListNode right)
        {

            var headPointer = new ListNode();
            var current = headPointer;
            while (left != null && right != null)
            {
                if (left.val > right.val)
                {
                    current.next = right;
                    right = right.next;
                }
                else
                {
                    current.next = left;
                    left = left.next;
                }

                current = current.next;
            }

            if (left != null)
            {
                current.next = left;
            }

            if (right != null)
            {
                current.next = right;
            }

            return headPointer.next;

        }

     private ListNode GetMiddle(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        var slow = head;
        var fast = head;
        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
    }