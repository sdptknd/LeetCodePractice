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
        var copiedNode = new Node(node.val);
        nodesMapping.Add(node, copiedNode);
        copiedNode.next = node.next == null ? null : (nodesMapping.TryGetValue(node.next, out var nextNode) ? nextNode : CopyListOnly(node.next, nodesMapping));
        copiedNode.random = node.random == null ? null : (nodesMapping.TryGetValue(node.random, out var randomNode) ? randomNode : CopyListOnly(node.random, nodesMapping));
        return copiedNode;
    }

}