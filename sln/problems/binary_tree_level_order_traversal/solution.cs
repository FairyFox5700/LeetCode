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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var queue = new Queue<TreeNode>();
        var list = new List<IList<int>>();
        if(root == null)
        {
            return list;
        }
        queue.Enqueue(root);
        while(queue.Count() > 0 )
        {
            var curList = new List<int> {};
            var count = queue.Count();
            while(count > 0)
            {
                var node = queue.Dequeue();
                curList.Add(node.val);
                if(node.left!=null)
                {
                    queue.Enqueue(node.left);
                }
                if(node.right!=null)
                {
                    queue.Enqueue(node.right);
                }
                count --;
            }
            list.Add(curList);
        }

        return list;
    }
}