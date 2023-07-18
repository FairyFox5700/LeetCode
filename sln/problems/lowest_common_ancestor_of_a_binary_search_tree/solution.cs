/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
  public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
  {
      var current = root;
      while (current !=null)
      {
          if (current.val > p.val && current.val > q.val)
          {
              current = current.left;
          }
          else if (current.val < p.val && current.val < q.val)
          {
              current = current.right;
          }
          else
          {
              break;
          }
      }
      return current;
  }

}