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
    public ListNode Partition(ListNode head, int x) {
        ListNode head1 = new ListNode(0);
        ListNode head2 = new ListNode(0);
        ListNode curr1 = head1;
        ListNode curr2 = head2;
        
        ListNode curr = head;
        while (curr != null)
        {
            if (curr.val < x)
            {
                curr1.next = curr;
                curr1 = curr;
            }
            else
            {
                curr2.next = curr;
                curr2 = curr;
            }
            curr = curr.next;
        }
        
        curr1.next = head2.next;
        curr2.next = null;
        return head1.next;
    }
}