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
        public int MinDepth(TreeNode root)
        {
            //bfs
            var ques = new Queue<TreeNode>();
            if (root == null)
            {
                return 0;
            }
            ques.Enqueue(root);
            var mincount = 0;
            while (ques.Count > 0)
            {
                var currentCount = ques.Count;
                Console.WriteLine(currentCount);
                mincount++;
                while (currentCount > 0)
                {
                    currentCount--;
                    var pop = ques.Dequeue();
                    if (pop.left == null && pop.right == null)
                    {
                        // leaf node
                        return mincount;
                    }
                    if (pop.left != null)
                    {
                        ques.Enqueue(pop.left);
                    }
                    if (pop.right != null)
                    {
                        ques.Enqueue(pop.right);
                    }
                }

            }

            return mincount;
        }
    }



    /* using dfs
   public class Solution
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            if(root.left == null)
            {
                return 1 +  MinDepth(root.right);
            }
            if(root.right == null)
            {
                return 1 +  MinDepth(root.left);
            }
            var left  = MinDepth(root.left);
            var right = MinDepth(root.right);

            return 1+ Math.Min(left, right);
        }
    }

    */