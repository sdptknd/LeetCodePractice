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
    public TreeNode SortedArrayToBST(int[] nums) {
        return SortedArrayToBST2(nums, 0, nums.Length - 1);
    }

    public TreeNode SortedArrayToBST2(int[] nums, int left, int right) {
        if(left > right) return null;
        // if(left == right) return new TreeNode(nums[left]);
        var middle = left + (right - left) / 2;
        return new TreeNode(nums[middle], 
            SortedArrayToBST2(nums, left, middle - 1), 
            SortedArrayToBST2(nums, middle+1, right));
    }
}