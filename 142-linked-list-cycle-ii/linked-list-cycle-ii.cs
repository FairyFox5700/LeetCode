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
    public ListNode DetectCycle(ListNode head) 
    {
        var tortoise = head;
        var hare = head;
        // checking hare and hare next reference in enough
        // bacause he is 2 times more speedy
        while(hare != null && hare.next!=null)
        {
            tortoise = tortoise.next;
            hare = hare.next.next;

            if(hare == tortoise)
                break;
        }

        // not a cycle
        if(hare == null || hare.next==null)
        {
            return null;
        }

        // move hare back
        hare = head;
        while(hare != tortoise)
        {
            tortoise = tortoise.next;
            hare = hare.next;
        }

        return hare;

    }
}