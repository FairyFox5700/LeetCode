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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1 == null && list2 == null){
            return null;
        }
        else if(list1 == null){
            return list2;
        }
        else if(list2 == null){
            return list1;
        }
        var first = list1;
         var second = list2;
        ListNode newLL = new ListNode();
        var current = newLL;
        while(first !=null && second!=null)
        {
            if(first.val >= second.val)
            {
                current.next = second;
                second = second.next;
            }
            else
            {
                current.next = first;
                first = first.next;
            }
            current = current.next;
        }
    while(first!=null)
    {
                current.next = first;
                first = first.next;
                 current = current.next;
    }
    while(second!=null)
    {
       current.next = second;
       second = second.next;
        current = current.next;
    }
    current.next =null;
    return newLL.next;
    }
}