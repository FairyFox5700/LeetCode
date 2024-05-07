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
    public ListNode SwapPairs(ListNode head)
    {

        var node = head;
        while(node!=null && node.next!=null)
        {
            var next = node.next;
            var temp = node.val;
            node.val = next.val;
            next.val = temp;
            node = node.next.next;
        }

        return head;

    }
}