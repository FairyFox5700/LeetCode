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
     private int _level = 0;

     private TreeNode _leftMost = null;
     public int FindBottomLeftValue(TreeNode root)
     {
         if(root== null)
         {
             return 0;
         }

         FindBottomLeftValue(root, 1);
         return _leftMost?.val?? 0;
     }

     public void FindBottomLeftValue(TreeNode root, int level)
     {
         if (root == null)
         {
             return ;
         }

         // once level was changed, we need to update the leftmost node
         if(_level < level)
         {
             _level = level;
             _leftMost = root;
         }

         FindBottomLeftValue(root.left, level+1);
         FindBottomLeftValue(root.right, level+1);
         return;
     }
 }