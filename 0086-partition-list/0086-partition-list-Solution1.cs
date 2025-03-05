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
        var partition1 = new ListNode();
        var partition2 = new ListNode();
        var par1Curr = partition1;
        var par2Curr = partition2;
        var curr = head;

        while(curr != null){
            if(curr.val < x) {
                par1Curr.next = curr;
                par1Curr = curr;
            } else {
                par2Curr.next = curr;
                par2Curr = curr;
            }
            curr = curr.next;
        }

        par2Curr.next = null;
        par1Curr.next = partition2.next;

        return partition1.next;
    }
}