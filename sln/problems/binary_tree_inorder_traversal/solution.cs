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
          public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            if (root == null)
            {
                return result;
            }
            var stack = new Stack<TreeNode>();
            var node = root;
            while (stack.Count > 0 || node != null)
            {
                // left
                // root
                // right
                if (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }
                else
                {
                    var pop = stack.Pop();
                    result.Add(pop.val);
                    node = pop.right;
                }
            }
            return result;
        }
}