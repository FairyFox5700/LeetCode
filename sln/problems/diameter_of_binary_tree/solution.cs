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
    private int max = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        // diameter should be left side + root + right side
        // thus, heaight of left + height of right
        GetHeight(root);
        return max;

    }

    public int GetHeight(TreeNode root)
    {
        if(root == null)
            return 0;
        
        var leftHeight = GetHeight(root.left);
        var rightHeight = GetHeight(root.right);
        max = Math.Max( leftHeight + rightHeight , max);
        //https://favtutor.com/blogs/binary-tree-height
        return Math.Max(leftHeight,rightHeight) +1;
    }
}
