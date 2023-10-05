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
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root.left);
            queue.Enqueue(root.right);
            while (queue.Count > 0)
            {
                var currentCount = queue.Count;
                var popLeft = queue.Dequeue();
                var popRight = queue.Dequeue();
                if (popLeft == null && popRight == null)
                {
                    continue;
                }

                if (popLeft == null || popRight == null)
                {
                    return false;
                }

                if (popLeft.val != popRight.val)
                {
                    return false;
                }

                queue.Enqueue(popLeft.left);
                queue.Enqueue(popRight.right);
                queue.Enqueue(popLeft.right);
                 queue.Enqueue(popRight.left);
            }

            return true;
        }
    }
 /*
    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            var node = root;

            if (root == null)
            {
                return true;
            }


            return IsSymmetric(root.left, root.right);
        }

        private bool IsSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }

            if (left == null || right == null)
            {
                return false;
            }

            if (left.val != right.val)
            {
                return false;
            }

            return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
        }
    }

    */