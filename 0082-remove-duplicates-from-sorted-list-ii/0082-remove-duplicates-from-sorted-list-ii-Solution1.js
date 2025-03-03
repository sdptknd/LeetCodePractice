/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @return {ListNode}
 */
var deleteDuplicates = function(head) {
    const starter = new ListNode();
    let lastNode = starter;
    let currNode = head;

    while(currNode != null){
        let traverseNode = currNode.next;
        let currValCounter = 1;

        while(traverseNode != null && traverseNode.val == currNode.val){
            currValCounter++;
            traverseNode = traverseNode.next;
        }

        if(currValCounter == 1){
            lastNode.next = currNode;
            lastNode = currNode;
        }

        currNode = traverseNode;
    }

    lastNode.next = null;

    return starter.next;
};