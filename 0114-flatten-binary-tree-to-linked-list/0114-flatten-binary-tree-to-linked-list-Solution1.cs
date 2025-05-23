/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    private TreeNode lastNode;

    public void Flatten(TreeNode root) {
        lastNode = new TreeNode();
        Flatten2(root);
    }

    public void Flatten2(TreeNode root) {
        if(root == null) return;

        var right = root.right;
        var left = root.left;
        lastNode.right = root;
        lastNode = lastNode.right;
        lastNode.left = null;
        lastNode.right = null;
        Flatten2(left);
        Flatten2(right);
    }
}