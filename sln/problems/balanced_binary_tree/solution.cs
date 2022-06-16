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
   public bool IsBalanced(TreeNode root)
        {
            return DFS(root).Item1;
        }


        //pre order traversal
        (bool, int) DFS(TreeNode? node)
        {
            if (node == null)
            {
                return (true, 0);
            }
            var left = DFS(node.left);
            var right = DFS(node.right);


            var balanced = left.Item1 && right.Item1 && Math.Abs(left.Item2 - right.Item2) <= 1;
            return (balanced, 1 + Math.Max(left.Item2, right.Item2));
        }
}