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
        return CopyListOnly(head, nodesMapping);
    }

    public Node CopyListOnly(Node node, Dictionary<Node, Node> nodesMapping) {
        if(node == null) return null;
        if(nodesMapping.ContainsKey(node)) return nodesMapping[node];
        var copiedNode = new Node(node.val);
        nodesMapping.Add(node, copiedNode);
        copiedNode.next = CopyListOnly(node.next, nodesMapping);
        copiedNode.random = CopyListOnly(node.random, nodesMapping);
        return copiedNode;
    }

}