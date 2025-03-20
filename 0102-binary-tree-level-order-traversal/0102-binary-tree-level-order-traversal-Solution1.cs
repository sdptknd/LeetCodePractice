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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var result = new List<IList<int>> ();
        if(root == null) return result;
        var currLevel = new List<TreeNode> { root };

        while(currLevel.Any()){
            // Console.WriteLine(string.Join(',', currLevel.Select(node => node.val)));
            result.Add(currLevel.Select(node => node.val).ToList());
            var newCurrLevel = new List<TreeNode>();
            currLevel.ForEach(node => {
                if(node.left != null) newCurrLevel.Add(node.left);
                if(node.right != null) newCurrLevel.Add(node.right);
            });
            currLevel = newCurrLevel;
        }

        return result;
    }
}