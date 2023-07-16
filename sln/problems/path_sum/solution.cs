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
        // root = [5,4,8,11,null,13,4,7,2,null,null,null,1], targetSum = 22
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }
            var currentSum = root.val;
            return DFS(root, 0, targetSum);
        }

        public bool DFS(TreeNode root, int currentSum, int targetSum)
        {
            if(root == null)
            {
                return false;
            }
            currentSum += root.val;
            if (root.left == null && root.right == null)// aka leaf node
            {
                return targetSum == currentSum;
            }
            return DFS(root.left, currentSum, targetSum) || DFS(root.right, currentSum, targetSum);
        }

        //trace
        /*
         * currentSum = 0
         * curentSum = 5
         * DFS(4, 5, 22)
         * DFS(8, 5, 22)
         * pop
         *  currentSum = 9
         * DFS(11, 9, 22)
         * DFS(null, 9, 22)
         * pop
         * currentSum =  5+8 = 13
         * DFS(13, 13, 22)
         * DFS(4, 13, 22)
         * pop
         * currensum= 9 + 11 = 20
         * DFS(7, 20, 22)
         * DFS(2, 20, 22)
         * pop
         * currensum = 9
         * leaf node: but !=target => return false
         * pop
         * currensum = 13 + 13 = 26
         * DFS(null, 26, 22)
         * DFS(null, 26, 22)
         * pop
         * currentsum = 13 + 4 = 17
         * DFS(5, 17, 22)
         * DFS( 1, 17, 22)
         *
         */
    }