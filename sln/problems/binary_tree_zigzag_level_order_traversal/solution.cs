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
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            var  queue = new Queue<TreeNode>();
            if(root == null)
            {
                return result;
            }
            queue.Enqueue(root);
            while (queue.Count() > 0)
            {
                var currentResult = new List<int>();
                var currentCount = queue.Count();
                while (currentCount > 0)
                {
                    var pop = queue.Dequeue();
                    currentResult.Add(pop.val);
                    if (pop.left != null)
                    {
                        queue.Enqueue(pop.left);
                    }
                    if (pop.right != null)
                    {
                        queue.Enqueue(pop.right);
                    }
                    currentCount--;
                }

                if (result.Count() % 2 == 1)
                {
                    currentResult.Reverse();
                }
                result.Add(currentResult);
            }

            return result;
        }
    }