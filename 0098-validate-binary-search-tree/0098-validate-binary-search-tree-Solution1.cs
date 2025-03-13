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
    public bool IsValidBST(TreeNode root) {
        return IsValidBST2(root).isValid;
    }

    public (bool isValid, int max, int min) IsValidBST2(TreeNode root) {
        var isValid = true;
        var max = root.val;
        var min = root.val;

        if(root.left != null){
            var leftResult = IsValidBST2(root.left);
            isValid = isValid && leftResult.isValid && leftResult.max < root.val;
            if(isValid) min = leftResult.min;
        }

        if(isValid && root.right != null){
            var rightResult = IsValidBST2(root.right);
            isValid = isValid && rightResult.isValid && rightResult.min > root.val;
            if(isValid) max = rightResult.max;
        }

        return (isValid, max, min);
    }
}