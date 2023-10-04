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
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            var stack = new Stack<TreeNode>();
            if(root==null) return result;
            stack.Push(root);

            while(stack.Count > 0)
            {
                var pop = stack.Pop();
                result.Add(pop.val);
                if(pop.left !=null)
                {
                    stack.Push(pop.left);
                }
                if(pop.right !=null)
                {
                   stack.Push(pop.right);
                }
            }
            var array = result.ToArray();
            Array.Reverse(array);
            return array.ToList();
        }
    }