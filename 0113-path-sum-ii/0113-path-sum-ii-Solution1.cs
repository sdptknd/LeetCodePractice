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
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        if(root == null) return [];

        if(root.left == null && root.right == null){
            return root.val == targetSum ? [[root.val]] : [];
        }

        IList<IList<int>> result = [];

        // Console.WriteLine(result.GetType().Name);

        foreach(var path in PathSum(root.left, targetSum-root.val)){
            path.Insert(0, root.val);
            result.Add(path);
        }

        foreach(var path in PathSum(root.right, targetSum-root.val)){
            path.Insert(0, root.val);
            result.Add(path);
        }

        return result;
    }
}