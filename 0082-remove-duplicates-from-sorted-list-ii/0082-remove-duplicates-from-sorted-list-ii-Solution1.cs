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
        var starter = new ListNode();
        var lastNode = starter;
        var currNode = head;

        while(currNode != null){
            var traverseNode = currNode.next;
            var currValCounter = 1;

            while(traverseNode != null && traverseNode.val == currNode.val) {
                currValCounter++;
                traverseNode = traverseNode.next;
            }

            if(currValCounter == 1) {
                lastNode.next = currNode;
                lastNode = currNode;
            }
            
            currNode = traverseNode;
        }

        lastNode.next = null;

        return starter.next;
    }
}