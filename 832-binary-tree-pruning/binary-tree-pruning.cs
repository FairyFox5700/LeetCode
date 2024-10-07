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
    public TreeNode PruneTree(TreeNode root) {
        if(root == null)
            return root;

        var result = IsForPruning(root);
        if(result == true)
            return null;
        return  root; // return modifed tree
    }

    private bool IsForPruning(TreeNode root)
    {
        if(root == null)// leaf node
        {
            return true;
        }

        var leftTrue = IsForPruning(root.left);
        var rightTrue =  IsForPruning(root.right);
        // pruning part
        if(leftTrue)
        {
           root.left = null;
        }
        if(rightTrue)
        {
           root.right = null;
        }

        return root.val == 0 && rightTrue && leftTrue;
    }
}