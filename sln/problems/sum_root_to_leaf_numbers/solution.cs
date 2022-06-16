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
               public int SumNumbers(TreeNode root)
        {
            return SumNumbersInternal(root, 0);
        }



        private int SumNumbersInternal(TreeNode root, int valueCurrent)
        {
            if (root == null)
            {
                return 0;
            }
           

            valueCurrent = valueCurrent * 10 + root.val;
             if (root.right == null && root.left == null)
            {
                return valueCurrent;
            }
            return (SumNumbersInternal(root.left, valueCurrent) + SumNumbersInternal(root.right, valueCurrent));
        }
}