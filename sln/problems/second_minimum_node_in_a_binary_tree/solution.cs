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
        public int FindSecondMinimumValue(TreeNode root)
        {
            return Serach(root, root.val);
        }

        private int Serach(TreeNode node, int target)
        {
            if (node == null)
            {
                return -1;
            }

            Console.WriteLine(node.val);
            if (node.val > target)
            {
                return node.val;
            }

            var left = Serach(node.left, target);
            var right = Serach(node.right, target);
                    if (left == -1 && right == -1)
        {
            return -1; // No second minimum value found.
        }
        else if (left == -1)
        {
            return right;
        }
        else if (right == -1)
        {
            return left;
        }
        else
        {
            return Math.Min(left, right);
        }
        }
    }
