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
    public ListNode ReverseList(ListNode head) {
        ListNode reversed = null;
        var curr = head;

        while(curr != null){
            var next = curr.next;
            curr.next = reversed;
            reversed = curr;
            curr = next;
        }

        return reversed;
    }
}