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
  public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortToBSTInternal(nums, 0, nums.Length-1);
        }

       private TreeNode SortToBSTInternal(int[] nums, int begining, int end)
        {
            if (begining > end)
                return null;
            var mid = (begining + end) / 2;
            var node = new TreeNode(nums[mid]);
            node.left = SortToBSTInternal(nums, begining, mid - 1);
            node.right = SortToBSTInternal(nums, mid + 1, end);
            return node;
        }
}