
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
public class Solution
{
    private TreeNode prevNode = null;
    public bool IsValidBST(TreeNode root)
    {
        // in order
        return InOrder(root);
    }


    private bool InOrder(TreeNode node)
    {
        if (node == null)
            return true;

        if(!InOrder(node.left)) return false;

        if (prevNode != null && node.val <= prevNode.val)
            return false;

        prevNode = node;

        
        return InOrder(node.right);
    }

    /*public bool IsValidBST(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }
        if (root.left == null && root.right == null)
        {
            return true;
        }
        return IsValid(root, long.MinValue, long.MaxValue);


        bool IsValid(TreeNode? node, long min, long max)
        {

            if (node == null)
            {
                return true;
            }

            if ((min >= node.val) || (max <= node.val))
            {
                return false;
            }
            return IsValid(node.left, min, node.val)
                   && IsValid(node.right, node.val, max);
        }
    }*/
}