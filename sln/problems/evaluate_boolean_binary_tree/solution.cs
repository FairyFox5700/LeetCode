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
        public bool EvaluateTree(TreeNode root)
        {
            return InOrder(root);
        }


        private bool GetBool(TreeNode node)
        {
            if (node == null)
            {
                return false;
            }

            if (node.val == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool InOrder(TreeNode node)
        {
            if (node.val == 2)
            {
                return InOrder(node.left) || InOrder(node.right);
            }
            else if(node.val==3)
            {
                return InOrder(node.left) && InOrder(node.right);
            }
            else
            {
                return GetBool(node);
            }
        }
    }