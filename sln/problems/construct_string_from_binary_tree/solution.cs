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
        private string Result = string.Empty;

        public string Tree2str(TreeNode root)
        {
            if (root == null)
            {
                return "";
            }
            DFS(root);

            return Result.Substring(1, Result.Length -2);
        }

        private void DFS(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Result += "(";
            Result += $"{node.val}";
            if (node.left == null && node.right != null)
            {
                Result += "()";
            }
            DFS(node.left);
            DFS(node.right);

            Result += ")";
        }
    }