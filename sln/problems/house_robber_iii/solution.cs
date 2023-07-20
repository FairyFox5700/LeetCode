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
  public int Rob(TreeNode root)
        {
            (int with, int without) = DFS(root);
            return Math.Max(with, without);
        }

        public (int withRoot, int withoutRoot) DFS(TreeNode node)
        {
            if (node == null)
            {
                return (0,0);
            }
            if (node.left == null && node.right == null)
            {
                return (node.val, 0);
            }

            var left = DFS(node.left);
            var right = DFS(node.right);

            var withRoot = node.val + left.withoutRoot + right.withoutRoot;

            // if we don't rob this node, we can rob its children and
            // get the max value from its children as we already calculated in the DFS
            // and rather it is with root ot without root
            // we can still rob these housed without alarm as they are not connected
            var withoutRoot = Math.Max(left.withRoot, left.withoutRoot) + Math.Max(right.withRoot, right.withoutRoot);

            return (withRoot, withoutRoot);
        }
}