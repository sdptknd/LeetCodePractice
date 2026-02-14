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
    public int KthSmallest(TreeNode root, int k) {
        return Inorder(root).Skip(k-1).Take(1).First();
    }

    private IEnumerable<int> Inorder(TreeNode node){
        if(node != null){
            foreach(var val in Inorder(node.left)) yield return val;
            yield return node.val;
            foreach(var val in Inorder(node.right)) yield return val;
        }
    }
}