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

        var currLevel = new List<Node> {root};

        while(currLevel.Any()){
            var newLevel = new List<Node> ();

            for(var i = 0; i < currLevel.Count - 1; i++){
                currLevel[i].next = currLevel[i+1];

                if(currLevel[i].left != null) newLevel.Add(currLevel[i].left);
                if(currLevel[i].right != null) newLevel.Add(currLevel[i].right);
            }

            if(currLevel[currLevel.Count - 1].left != null) newLevel.Add(currLevel[currLevel.Count - 1].left);
            if(currLevel[currLevel.Count - 1].right != null) newLevel.Add(currLevel[currLevel.Count - 1].right);

            currLevel = newLevel;
        }

        return root;
    }
}