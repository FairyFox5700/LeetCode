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
        public bool FindTarget(TreeNode root, int k)
        {
            var hasmap = new HashSet<int>();
            if(root.left == null && root.right ==null)
            {
                return false;
            }
            return DFS(root, hasmap, k);
        }

        private bool DFS(TreeNode node,HashSet<int> hash, int k)
        {
            if (node == null)
            {
                return false;
            }

            var val = k - node.val;
           
            if(hash.Contains(val))
            {
                return true;
            }
             if (!hash.Contains(node.val))
            {
                hash.Add(node.val);
            }

            var left = DFS(node.left, hash, k);
            var right = DFS(node.right, hash, k);

            return left || right;
        }
    }