/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @param {number} targetSum
 * @return {number[][]}
 */
var pathSum = function(root, targetSum) {
    if(root === null) return [];

    if(root.left === null && root.right === null)
        return root.val === targetSum ? [[root.val]] : [];

    const childPaths =
        [...pathSum(root.left, targetSum - root.val),
         ...pathSum(root.right, targetSum - root.val)]

    return childPaths.map(path => [root.val, ...path]);
};