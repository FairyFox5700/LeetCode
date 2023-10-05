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
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            var result = new List<int>();
            if (root == null)
            {
                return result;
            }
            stack.Push(root);
            while (stack.Count > 0)
            {
                var item = stack.Pop();
                result.Add(item.val);
                if (item.right != null)
                {
                   stack.Push(item.right);
                }
                if (item.left != null)
                {
                    stack.Push(item.left);
                }
            }
            return result;
        }
    }