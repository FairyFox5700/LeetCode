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
    public ListNode MiddleNode(ListNode head) {
        var len = GetLength(head);
        int mid = len / 2;
        var cur =head;
        for(int i = 0; i< mid; i++)
        {
            cur = cur.next;
        }
        return cur;
    }

    public int GetLength(ListNode head)
    {
        var len = 0;
        var cur =head;
        while(cur!=null)
        {
           cur = cur.next;
           len++;
        }
        return len;
    }
}