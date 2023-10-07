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

        private TreeNode prevTreeNode = null;
        private TreeNode first = null;
        private TreeNode second = null;
        public void RecoverTree(TreeNode root)
        {
            InOrder(root);
            (first.val, second.val) = (second.val, first.val);
        }
        private void InOrder(TreeNode node)
        {

            if (node == null)
            {
                return;
            }

            InOrder(node.left);
            var prevVal = prevTreeNode?.val??0;
            if (prevVal > node.val)
            {
                if (first == null)
                {
                    first = prevTreeNode;
                }
                second = node;
            }

            prevTreeNode = node;
            InOrder(node.right);
        }
    }