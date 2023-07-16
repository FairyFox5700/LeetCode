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
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            // preorder = [3,9,20,15,7]
            // R, L , R, L , R
            // inorder = [9,3,15,20,7]
            // L, Rot, L, R, Ri,

            if (!preorder.Any() || !inorder.Any())
            {
                return null;
            }
            // first value in preorder is root
            var root = new TreeNode(preorder[0]);
            var indexofRootInInorder = Array.IndexOf( inorder, root.val);
            var leftInorder = inorder.Take(indexofRootInInorder).ToArray();
            var leftPreorder = preorder.Skip(1).Take(leftInorder.Count()).ToArray();
            var rightInorder = inorder.Skip(indexofRootInInorder + 1).ToArray();
            var rightPreorder = preorder.Skip(leftInorder.Count() + 1).ToArray();
            root.left = BuildTree(leftPreorder, leftInorder);
            root.right = BuildTree(rightPreorder, rightInorder);
            return root;
        }
        // tracing
        /*
         *  root = 3
         * root.left  = BuildTree([9],[9])
         * root.right = BuildTree([20,15,7],[15,20,7])
         * left;
         * root = 9
         * root.left = BuildTree([],[])
         * root.right = BuildTree([],[])
         * root9.null = null
         * pop stack
         * rooot3.left = root9
         * right
         * root = 20
         * root.left = BuildTree([15],[15])
         * root.right = BuildTree([7],[7])
         * root = 15
         * root.left = BuildTree([],[])
         * root.right = BuildTree([],[])
         * root15.left = null
         * pop stack
         * root20.left = root15
         * right
         * root = 7
         * root.left = BuildTree([],[])
         * root.right = BuildTree([],[])
         * pop stack
         * roo7.left = null
         * root7.right = null
         * roo20.right = root7
         * 
         */
    }