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
    public int KthSmallest(TreeNode root, int k) {
        // in-order but iterative traversal
        var queue = new Stack<TreeNode>();
        var array = new List<int>();
        var current = root;
  
        while (queue.Count() > 0 || current!=null)
        {
            while(current != null)
            {
                queue.Push(current);
                current = current.left;
            }
            var pop = queue.Pop();
            array.Add(pop.val);
            current = pop.right;
        }
         Console.WriteLine( string.Join( " ", array));
        if(k> array.Count())
        {
            return -1;
        }
        return array.Skip(k -1).Take(1).ToList()[0];
    }
}