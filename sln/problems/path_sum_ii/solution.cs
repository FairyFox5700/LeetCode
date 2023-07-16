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
        //[5,4,8,11,null,13,4,7,2,null,null,5,1] targetSum = 22
        public List<IList<int>> Result = new List<IList<int>>();
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            // in-order traversal
            if (root == null)
            {
                return Result;
            }

            var result = new List<int>();
            DFS(root, result,0, targetSum);
            return Result.Where(e => e.Any()).ToList();
        }

        public List<int> DFS(TreeNode root, List<int> result, int currentSum, int targetSum)
        {
            if (root == null)
            {
                return result;
            }
            currentSum += root.val;
            result.Add(root.val);
            if (root.left == null && root.right == null && targetSum == currentSum)// aka leaf node
            {
                Result.Add(new List<int>(result));
            }

            DFS(root.left, new List<int>(result),currentSum, targetSum);
            DFS(root.right, new List<int>(result), currentSum, targetSum);

            return result;

            //trace
            /*
             * result = []
             * DFS(root, result, 0, 22)
             * currentSum = 5
             * result = [5]
             * DFS (4, result, 5, 22)
             * DFS(8, result, 5, 22)
             * currentsum = 5+ 4 = 9
             * result = [5,4]
             * DFS(11, result, 9, 22)
             * DFS(null, result, 9, 22)
             * currentsum = 8 + 5 = 13
             * result = [5, 8]
             * DFS (13, result, 13, 22)
             * DFS(4, result, 13, 22)
             * currentsum = 11 + 9 = 20
             * result = [5, 4, 11]
             * DFS(7, result, 20, 22)
             * DFS(2, result, 20, 22)
             * currentSum = 13 + 13 = 26
             * result = [5, 8, 13]
             * DFS(null, result, 26, 22)
             * DFS(null, result, 26, 22)
             * currentSum = 13 + 4 = 17
             * result = [5, 8, 4]
             * DFS(5, result, 17, 22)
             * DFS(1, result, 17, 22)
             * currentSum = 7 + 20 = 27
             * result = [5, 4, 11, 7]
             * DFS(null, result, 27, 22)
             * DFS(null, result, 27, 22)
             * currentsum = 20 + 2 = 22
             * result = [5, 4, 11, 2]
             * DFS(null, result, 22, 22)
             * DFS(null, result, 22, 22)
             */
        }
    }