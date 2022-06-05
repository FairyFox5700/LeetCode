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

 
public class Solution {
 

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode current = head;
            var carry = 0;
            while (l1 != null || l2 != null)
            {
                var x = l1 != null ? l1.val : 0;
                var y = l2 != null ? l2.val : 0;
                var digit = carry + x + y;
                carry = digit /10;
                current.next = new ListNode(digit%10);
                current = current.next;
                if(l1 != null) { l1 = l1.next;}
                if(l2 != null) { l2 = l2.next;}
            }
        // last digit with overflow (9,9) in the end => 01
        if(carry > 0){ current.next = new ListNode(carry); }
            return head.next;
        }
}
      