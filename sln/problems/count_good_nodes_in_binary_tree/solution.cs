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
        private int Count = 0;
        public int GoodNodes(TreeNode root)
        {
            var maxSoFar = Int32.MinValue;
            DFS(root, maxSoFar);

            return Count;
        }

        private void DFS(TreeNode node, int max)
        {
            if (node == null)
            {
                return;
            }

            if (node.val >= max)
            {
                Count++;
            }

            DFS(node.left, Math.Max(max, node.val));
            DFS(node.right, Math.Max(max, node.val));
        }
    }