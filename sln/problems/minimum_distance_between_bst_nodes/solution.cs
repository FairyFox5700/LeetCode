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

        private int currentMin = int.MaxValue;
        private int prev = int.MaxValue;
        public int MinDiffInBST(TreeNode root)
        {
            return DFS(root);
        }

        private int DFS(TreeNode node)
        {
            if (node == null)
            {
                return currentMin;
            }

            // using in order approach we eliminate th need fot sorting, as it returns nodes in sorted order
            DFS(node.left);
            var diff = Math.Abs(node.val - prev);
            if (diff < currentMin)
            {
                currentMin = diff;
            }
            prev = node.val;
            DFS(node.right);
            return currentMin;
        }
    }