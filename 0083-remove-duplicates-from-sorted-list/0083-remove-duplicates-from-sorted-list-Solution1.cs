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
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null) return head;

        var lastNode = head;
        var currNode = head.next;

        while(currNode != null){
            if(currNode.val == lastNode.val){
                currNode = currNode.next;
                continue;
            }
            lastNode.next = currNode;
            lastNode = currNode;
            currNode = currNode.next;
        }

        lastNode.next = null;

        return head;
    }
}