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
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            var root = new TreeNode();
            

            return Item(nums, 0, nums.Length);
        }

        private TreeNode Item(int[] nums, int beg, int end)
        {
            if (beg ==end)
            {
                return null;
            }

      var max = nums[beg];
        var maxIndex = beg;

            for (int i = beg; i < end; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine(max);
            var node = new TreeNode(max);
            node.left = Item(nums, beg, maxIndex);
            node.right = Item(nums, maxIndex + 1, end);

            return node;
        }
    }