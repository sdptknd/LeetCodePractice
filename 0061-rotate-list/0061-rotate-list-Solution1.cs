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
    public ListNode RotateRight(ListNode head, int k) {
        if(head == null) return head;

        var (nodesCount, lastNode) = Count(head);

        var shift = k % nodesCount;

        if(shift == 0) return head;

        var curr = head;
        var count = 1;
        
        while(count < nodesCount - shift){
            count++;
            curr = curr.next;
        }

        var newHead = curr.next;
        curr.next = null;
        lastNode.next = head;

        return newHead;
    }

    public (int, ListNode) Count(ListNode head){
        var count = 0;
        var curr = head;
        while(curr.next != null){
            count++;
            curr = curr.next;
        }
        return (count + 1, curr);
    }
}