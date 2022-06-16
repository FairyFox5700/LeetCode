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
        public bool IsValidBST(TreeNode root)
        {
            var result = true;
            //check root
            result &= IsValidBSTInternal(root,  double.MaxValue,double.MinValue);
            return result;
        }

        private bool IsValidBSTInternal(TreeNode root, double rightBound, double leftBound)
        {
            var result = true;
            if (root == null)
            {
                return true;
            }
            if (root.val >= rightBound || root.val <= leftBound)
            {
                return false;
            }
            result &= IsValidBSTInternal(root.left, root.val, leftBound);// must be lower then root
            result &= IsValidBSTInternal(root.right, rightBound, root.val);// must be greater then root
            return result;
        }
}