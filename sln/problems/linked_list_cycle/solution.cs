/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        //https://www.geeksforgeeks.org/detect-loop-in-a-linked-list/
        var slow = head;
        if(slow == null)
        {
            return false;
        }
        var fast = slow.next;
        while (fast!=null && fast.next !=null)
        {
            if(slow == fast)
            {
                return true;
            }
            slow = slow.next;
            fast = fast.next.next;
           
        }

        return false;
    }
}