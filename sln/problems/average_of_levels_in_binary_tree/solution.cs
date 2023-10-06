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
        public IList<double> AverageOfLevels(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            if (root == null)
            {
                return new List<double>();
            }
            queue.Enqueue(root);
            var result = new List<double>();
            while (queue.Count > 0)
            {
                var currentCount = queue.Count;
                double elNumber = queue.Count;
                double currentSum = 0;
                while (currentCount >0)
                {
                    var pop = queue.Dequeue();
                    currentSum+=pop.val;
                    if (pop.left != null)
                    {
                        queue.Enqueue(pop.left);
                    }
                    if (pop.right != null)
                    {
                        queue.Enqueue(pop.right);
                    }

                    if (currentCount == 0)
                    {
                        result.Add(pop.val);
                    }
                    currentCount--;
                }

                result.Add(currentSum /(double) elNumber);
            }

            return result;
        }
    }