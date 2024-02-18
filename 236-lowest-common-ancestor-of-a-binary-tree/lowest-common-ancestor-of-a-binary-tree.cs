public class Solution
{
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {

            var stack = new Stack<TreeNode>();
            stack.Push(root);
            var parent = new Dictionary<TreeNode, TreeNode>();
            parent.Add(root, null);
  while (stack.Count >0)
    {
                var current = stack.Pop();
                if (current.left != null)
                {
                    parent.Add(current.left, current);
                    stack.Push(current.left);
                }

                if (current.right != null)
                {
                    parent.Add(current.right, current);
                    stack.Push(current.right);
                }
            }

            var ancestorsOfP = new HashSet<TreeNode>();
            while (p!=null)
            {
                 ancestorsOfP.Add(p);
                var anc = parent[p];
                p = anc;
            }

            while ( !ancestorsOfP.Contains(q))
            {
                var ans = parent[q];
                q = ans;
            }

            return q;
        }
    /*
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

    */
}
