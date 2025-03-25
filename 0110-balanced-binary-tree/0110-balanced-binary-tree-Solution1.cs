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
    public bool IsBalanced(TreeNode root) {
        return IsBalanced2(root).balanced;
    }

    public (bool balanced, int depth) IsBalanced2(TreeNode node) {
        if(node == null) return (true, 0);

        var leftResult = IsBalanced2(node.left);
        var rightResult = IsBalanced2(node.right);

        if(!leftResult.balanced 
            || !rightResult.balanced 
            || Math.Abs(leftResult.depth - rightResult.depth) > 1) return (false, -1);

        return (true, Math.Max(leftResult.depth, rightResult.depth) + 1);
    }
}