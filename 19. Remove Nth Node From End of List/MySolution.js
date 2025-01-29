/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} n
 * @return {ListNode}
 */
var removeNthFromEnd = function(head, n) {
    let currentNode = head;
    for(let i = 0; i<n; i++){
        if(currentNode.next == null) return head.next;
        currentNode = currentNode.next;
    }
    let nthPrevNode = head;
    while(currentNode.next !== null){
        currentNode = currentNode.next;
        nthPrevNode = nthPrevNode.next;
    }
    nthPrevNode.next = nthPrevNode.next.next;
    return head;
};