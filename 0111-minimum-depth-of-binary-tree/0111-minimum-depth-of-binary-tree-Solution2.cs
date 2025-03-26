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
    public int MinDepth(TreeNode root) {
        if(root == null) return 0;

        var leftMinDepth = MinDepth(root.left);
        var rightMinDepth = MinDepth(root.right);

        if(leftMinDepth == 0 && rightMinDepth == 0) return 1;
        if(leftMinDepth > 0 && rightMinDepth > 0) return 1 + Math.Min(leftMinDepth, rightMinDepth);
        if(leftMinDepth == 0) return 1 + rightMinDepth;
        return 1 + leftMinDepth;
    }
}