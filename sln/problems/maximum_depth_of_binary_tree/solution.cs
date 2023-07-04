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
    public int MaxDepth(TreeNode root) {
        var max = GetHeight(root);
        return max;
    }

    public int GetHeight(TreeNode root)
    {
        if(root == null)
            return 0;
        var leftHeiht = GetHeight(root.left);
        var rightHeiht = GetHeight(root.right);
        return Math.Max(leftHeiht,rightHeiht) +1;
    }
}