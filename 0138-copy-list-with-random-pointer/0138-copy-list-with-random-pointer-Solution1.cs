/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        var nodesMapping = new Dictionary<Node, Node> ();
        var listCopy = CopyListOnly(head, nodesMapping);
        var currNode = listCopy;

        while(currNode != null){
            if(currNode.random != null)
                currNode.random = nodesMapping[currNode.random];
            currNode = currNode.next;
        }

        return listCopy;
    }

    public Node CopyListOnly(Node node, Dictionary<Node, Node> nodesMapping) {
        if(node == null) return null;
        var copiedNode = new Node(node.val);
        copiedNode.next = CopyListOnly(node.next, nodesMapping);
        copiedNode.random = node.random;
        nodesMapping.Add(node, copiedNode);
        return copiedNode;
    }

}