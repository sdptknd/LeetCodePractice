/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        if(root == null) return root;

        List<Node> currNodes = [root];

        while(currNodes.Any()){
            var newCurrNodes = new List<Node>();
            for(var i = 0; i < currNodes.Count - 1; i++){
                currNodes[i].next = currNodes[i+1];
                if(currNodes[i].left != null)
                    newCurrNodes.Add(currNodes[i].left);
                if(currNodes[i].right != null)
                    newCurrNodes.Add(currNodes[i].right);
            }
            if(currNodes[currNodes.Count-1].left != null)
                newCurrNodes.Add(currNodes[currNodes.Count-1].left);
            if(currNodes[currNodes.Count-1].right != null)
                newCurrNodes.Add(currNodes[currNodes.Count-1].right);
            currNodes = newCurrNodes;
            // Console.WriteLine(string.Join(',', currNodes.Select(n => n.val)));
        }

        return root;
    }
}