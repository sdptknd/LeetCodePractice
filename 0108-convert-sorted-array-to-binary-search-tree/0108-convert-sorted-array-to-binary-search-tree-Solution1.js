/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {number[]} nums
 * @return {TreeNode}
 */
var sortedArrayToBST = function(nums) {
    return sortedArrayToBST2(nums, 0, nums.length-1);
};

const sortedArrayToBST2 = (nums, left, right) => {
    if(left > right) return null;
    const middle = Math.floor(left + (right - left) / 2);
    return new TreeNode(nums[middle], sortedArrayToBST2(nums, left, middle-1), sortedArrayToBST2(nums, middle+1, right));
};