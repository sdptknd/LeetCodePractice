/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null) return null;

        return Dfs(node, new Dictionary<Node, Node>());
    }

    public Node Dfs(Node node, Dictionary<Node, Node> visited){
        Node clonedNode;

        if(visited.TryGetValue(node, out clonedNode)) return clonedNode;

        clonedNode = new Node(node.val);
        visited[node] = clonedNode;

        foreach(var neighbor in node.neighbors){
            clonedNode.neighbors.Add(Dfs(neighbor, visited));
        }

        return clonedNode;
    }
}