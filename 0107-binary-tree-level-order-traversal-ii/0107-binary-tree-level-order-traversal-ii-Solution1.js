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
 * @return {number[][]}
 */
var levelOrderBottom = function(root) {
    const result = [];
    if(root === null) return result;

    let currLevel = [root];

    while(currLevel.length > 0){
        const newCurrLevel = [];
        const currLevelVal = [];
        for(let node of currLevel){
            currLevelVal.push(node.val);
            node.left !== null && newCurrLevel.push(node.left);
            node.right !== null && newCurrLevel.push(node.right);
        }
        currLevel = newCurrLevel;
        result.unshift(currLevelVal);
    }

    return result;
};