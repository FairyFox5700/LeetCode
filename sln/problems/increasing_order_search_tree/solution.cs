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
        public TreeNode IncreasingBST(TreeNode root)
        {
            var result = new TreeNode();
            var referenceToRoot = result;
            InOrder(root, ref referenceToRoot);
            return result.right;

            // in order
        }

        private void InOrder(TreeNode node, ref TreeNode result)
        {
            if (node == null)
            {
                return;
            }
            InOrder(node.left,ref result);
            node.left = null;            
            result.right = node;
            result = node;
            InOrder(node.right, ref result);
        }
    }
