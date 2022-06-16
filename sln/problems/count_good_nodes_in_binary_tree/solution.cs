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
 public int GoodNodes(TreeNode root)
        {
            return DFS(root, Int32.MinValue);
        }

        private int DFS(TreeNode root, int maxVal)
        {
            if (root == null)
            {
                return 0;
            }

            int count = 0;
            if (root.val >= maxVal)
            {
                maxVal = root.val;
                count += 1;
            }

            count +=  DFS(root.left, maxVal);
            count += DFS(root.right, maxVal);
            return count;
        }
}