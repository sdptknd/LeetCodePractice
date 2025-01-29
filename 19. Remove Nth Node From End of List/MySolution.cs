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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var currentNode = head;
        for(int i = 0; i < n; i++) {
            if(currentNode.next == null) return head.next;
            currentNode = currentNode.next;
        }
        var nthPrevNode = head;
        while(currentNode.next != null){
            currentNode = currentNode.next;
            nthPrevNode = nthPrevNode.next;
        }
        nthPrevNode.next = nthPrevNode.next.next;
        return head;
    }
}