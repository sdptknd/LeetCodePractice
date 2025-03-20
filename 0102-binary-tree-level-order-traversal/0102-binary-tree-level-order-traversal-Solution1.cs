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
            currLevel = 
                currLevel
                .SelectMany(node => new List<TreeNode> {node.left, node.right})
                .Where(node => node != null).ToList();
        }

        return result;
    }
}