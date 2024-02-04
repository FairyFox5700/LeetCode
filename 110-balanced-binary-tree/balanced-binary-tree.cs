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

    private int GetHeight(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }
        int leftHeight = GetHeight(root.left);
        if(leftHeight == -1)
            return -1; 
        int rightHeight = GetHeight(root.right);
        if( rightHeight == -1)
                return -1;
        if(Math.Abs(leftHeight - rightHeight) > 1)
            return -1; // child at this steps are no optimized
        return Math.Max(leftHeight, rightHeight)+1;
    }

    public bool IsBalanced(TreeNode root) {
        if(root == null)
        {
            // already balanced
            return true;
        }
        // height of any node = 1 * max( heigh of its left child , height of tight child)
        return GetHeight(root) != -1;
    }
}