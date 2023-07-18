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
public class Solution {
        public TreeNode TrimBST(TreeNode root, int low, int high)
        {
            return DFS(root, low, high);
        }

        public TreeNode DFS(TreeNode node, int low, int high)
        {
            if (node == null)
            {
                return node;
            }
            if (node.val < low)
            {
                node.left = null;
                return DFS(node.right, low, high);
            }
            if (node.val > high)
            {
                node.right = null;
                return DFS(node.left, low, high);
            }
            node.left = DFS(node.left, low, high);
            node.right = DFS(node.right, low, high);
            return node;

        }
}