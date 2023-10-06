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

        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            List<int> _first = new List<int>();
            List<int> _second = new List<int>();

            DFS(root1, _first);
            DFS(root2, _second);

            return _first.SequenceEqual(_second);
        }

        private void DFS(TreeNode node, List<int> result)
        {
            if (node == null)
            {
                return;
            }
            if (node.left == null && node.right == null)
            {
               result.Add(node.val);
            }
            DFS(node.left, result);
            DFS(node.right, result);
        }
    }