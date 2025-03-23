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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        var result = new List<IList<int>>();
        if(root == null) return result;

        var currLevel = new List<TreeNode> {root};

        while(currLevel.Any()){
            var currLevelVal = new List<int>();
            var newCurrLevel = new List<TreeNode>();
            foreach(var node in currLevel){
                currLevelVal.Add(node.val);
                if(node.left != null) newCurrLevel.Add(node.left);
                if(node.right != null) newCurrLevel.Add(node.right);
            }
            currLevel = newCurrLevel;
            result.Insert(0, currLevelVal);
        }

        return result;
    }
}