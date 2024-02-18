public class Solution
{
    private TreeNode result = null;

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        RecursiveInOrder(root, p, q);
        return result;
    }

    public bool RecursiveInOrder(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null)
        {
            return false;
        }

        bool mid = (root == p || root == q);
        bool left = RecursiveInOrder(root.left, p, q);
        bool right = RecursiveInOrder(root.right, p, q);

        if ((left && right) || (mid && (left || right)))
        {
            result = root;
        }

        return mid || left || right;
    }
}
