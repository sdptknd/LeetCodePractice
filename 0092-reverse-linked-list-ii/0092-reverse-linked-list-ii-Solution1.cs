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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        var resultHead = new ListNode(-1, head);
        var count = 1;
        var curr = resultHead;

        while(count < left) {
            curr = curr.next;
            count++;
        }

        var firstPartEnd = curr;
        curr = curr.next;
        var reverseEnd = curr;
        ListNode reversed = null;

        while(count <= right) {
            var next = curr.next;
            curr.next = reversed;
            reversed = curr;
            curr = next;
            count++;
        }

        firstPartEnd.next = reversed;
        reverseEnd.next = curr;

        return resultHead.next;
    }
}