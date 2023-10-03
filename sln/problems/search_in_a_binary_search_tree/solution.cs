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
        public TreeNode SearchBST(TreeNode root, int val)
        {
            return Search(root, val);
        }

        private TreeNode Search(TreeNode node, int val)
        {
            if (node == null)
            {
                return null;
            }

            if (node.val == val)
            {
                return node;
            }

            if (node.val > val)
            {
                return Search(node.left, val);
            }
            return Search(node.right, val);
        }
    }
