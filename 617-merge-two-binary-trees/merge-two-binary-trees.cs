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
     public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            // base cases:
            if (root1 == null && root2 == null)
            {
                return null;
            }
            var firstval =  root2?.val??0;
            Console.WriteLine(firstval);
            var secval =  root1?.val??0;
            Console.WriteLine(secval);
            var result = firstval + secval;
            var node = new TreeNode(result);
            node.left = MergeTrees(root1?.left, root2?.left);
            node.right = MergeTrees(root1?.right, root2?.right);

            return node;

        }
    }