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
    public int SumNumbers(TreeNode root) {
        return SumNumbers2(root, 0);
    }

    public int SumNumbers2(TreeNode node, int currNum) {
        var updatedNum = (currNum * 10) + node.val;

        if(node.left == null && node.right == null)
            return updatedNum;
        
        var sum = 0;

        if(node.left != null) 
            sum += SumNumbers2(node.left, updatedNum);

        if(node.right != null) 
            sum += SumNumbers2(node.right, updatedNum);

        return sum;
    }
}