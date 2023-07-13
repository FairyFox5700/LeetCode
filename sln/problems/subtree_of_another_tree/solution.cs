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
        //BST
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            //level order traversal
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var node = root;
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current.val == subRoot.val && isIdentical(current, subRoot))
                {
                    return true;
                }
                if( current.left != null)
                {
                    queue.Enqueue(current.left);
                }
                 if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }
            return false;

            bool isIdentical(TreeNode node, TreeNode target)
            {
                if (node == null && target == null)
                {
                    return true;
                }
                else if (node == null || target == null)
                {
                    return false;
                }
                else if (node.val != target.val)
                {
                    return false;
                }
                else
                {
                    return isIdentical(node.left, target.left) && isIdentical(node.right, target.right);
                }
            }
        }
    }