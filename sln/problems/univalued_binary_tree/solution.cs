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

 // aslo can be done with array, to collect all values, using any approach of traversal, and compare the values in array
    public class Solution
    {
        public bool IsUnivalTree(TreeNode root)
        {
            var current = root.val;

            return InOrder(root, current);
        }

        private bool InOrder(TreeNode node, int current)
        {
            if (node == null)
            {
                return true;
            }
            else if (node.val == current)
            {
                return InOrder(node.left, current) && InOrder(node.right, current);
            }
            else
            {
                return false;
            }
        }
    }