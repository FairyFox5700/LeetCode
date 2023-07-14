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
    //https://www.geeksforgeeks.org/print-right-view-binary-tree-2/
    public IList<int> RightSideView(TreeNode root) {
        // lvel order
        var output = new List<int>();
        var queue = new Queue<TreeNode>();
        if(root == null)
        {
            return output;
        }
        queue.Enqueue(root);
        while(queue.Count() > 0)
        {
            TreeNode val = null;
            var count = queue.Count();
            for(int i = 0; i< count ; i++)
            {
                val = queue.Dequeue();
                            var left = val.left;
            if(left != null)
            {
                 queue.Enqueue(left);
            }
            var right = val.right;
            if(right != null)
            {
                 queue.Enqueue(right);
            }
            }
            if(val != null)
            {
                output.Add(val.val);
            }

        }
        return output;
        
    }
}