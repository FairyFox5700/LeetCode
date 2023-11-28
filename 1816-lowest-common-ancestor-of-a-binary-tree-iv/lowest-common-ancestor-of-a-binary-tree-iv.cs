/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode[] nodes)
        {
            if(root == null)
                return null;
            for (int i = 0; i < nodes.Length; i++)
            {
                if(root == nodes[i])
                {
                     return root;
                }
            }
            var left = LowestCommonAncestor(root.left, nodes);
            var right = LowestCommonAncestor(root.right, nodes);
            if(left != null && right != null)
                 return root;
            return left != null ? left : right;
        }
    }