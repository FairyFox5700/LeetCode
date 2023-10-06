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
        private int sum = 0;
        public int SumOfLeftLeaves(TreeNode root)
        {
            DFS(root,false);
            return sum;
        }

        private void DFS(TreeNode node, bool isLeft)
        {
            if (node == null)
            {
                return;
            }

            DFS(node.left, true);
            if (isLeft && node.left == null && node.right == null)
            {
                sum += node.val;
            }
            DFS(node.right, false);
        }
    }
