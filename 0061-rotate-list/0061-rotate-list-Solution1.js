/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} k
 * @return {ListNode}
 */
var rotateRight = function(head, k) {
    if(head == null) return head;

    let lastNode = head;
    let nodesCount = 0;
    while(lastNode.next != null){
        nodesCount++;
        lastNode = lastNode.next;
    }
    nodesCount++;

    const shift = k % nodesCount;
    
    if(shift == 0) return head;

    let curr = head;
    let count = 1;

    while(count < nodesCount - shift){
        count++;
        curr = curr.next;
    }

    const newHead = curr.next;
    curr.next = null;
    lastNode.next = head;

    return newHead;
};