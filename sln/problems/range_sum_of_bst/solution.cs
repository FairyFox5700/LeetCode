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
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            return InOrder(root, low, high);
        }

        private int InOrder(TreeNode node, int low, int high)
        {
            if (node == null)
            {
                return 0;
            }
            if (node.val < low)
            {
                return InOrder(node.right, low, high);
            }
            else if (node.val > high)
            {
                return  InOrder(node.left, low, high);
            }
            else
            {
                return node.val+ InOrder(node.right, low, high) + InOrder(node.left, low, high);
            }
        }
    }