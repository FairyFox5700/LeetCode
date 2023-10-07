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
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Count() == 0)
            {
                return null;
            }

            return InOrder(0, nums.Length, nums);
        }

        private TreeNode InOrder(int begining, int end, int[] nums)
        {
            if (begining >= end)
            {
                return null;
            }
            var mid = (begining + end) / 2;
            var root = new TreeNode(nums[mid]);
            root.left = InOrder(begining, mid, nums);
            root.right = InOrder(mid+1, end, nums);
            return root;
        }
    }