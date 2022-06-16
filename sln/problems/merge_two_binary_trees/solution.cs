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
  public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            var val = 0;
            if (root1 == null && root2 == null)
            {
                return null;
            }
            if (root1 == null)
            {
                val = root2.val;

            }

            if (root2 == null)
            {
                val = root1.val;
            }

            if (root1 != null && root2 != null)
            {
                val = root1.val + root2.val;
            }

            var newNode = new TreeNode(val);
            var left = MergeTrees(root1?.left, root2?.left);
            var right = MergeTrees(root1?.right, root2?.right);
            newNode.left = left;
            newNode.right = right;
            return newNode;
        }
}