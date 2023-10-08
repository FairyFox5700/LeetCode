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

     public class BSTIterator
    {
        private Stack<TreeNode> stack = new Stack<TreeNode>();
        public BSTIterator(TreeNode root)
        {
            ProcessLeftBranch(root);
        }

        private void ProcessLeftBranch(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            stack.Push(node);
            ProcessLeftBranch(node.left);
        }
        public int Next()
        {
            var pop = stack.Pop();
            if (pop.right != null)
            {
                ProcessLeftBranch(pop.right);
            }

            return pop.val;
        }

        public bool HasNext()
        {
            return stack.Count > 0;
        }
    }
    /*
    public class BSTIterator
    {
        private Queue<int> values = new Queue<int>();
        public BSTIterator(TreeNode root)
        {
            InOrder(root);
        }

        private void InOrder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            InOrder(node.left);
            values.Enqueue(node.val);
            InOrder(node.right);
        }
        public int Next()
        {
            return values.Dequeue();
        }

        public bool HasNext()
        {
            return values.Count > 0;
        }
    }
    */
/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */