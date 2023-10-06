    public class Solution
    {

        private int currentMin = int.MaxValue;
        private int prev = int.MaxValue;
        public int GetMinimumDifference(TreeNode root)
        {
            return DFS(root);
        }

        private int DFS(TreeNode node)
        {
            if (node == null)
            {
                return currentMin;
            }

            // using in order approach we eliminate th need fot sorting, as it returns nodes in sorted order
            DFS(node.left);
            var diff = Math.Abs(node.val - prev);
            if (diff < currentMin)
            {
                currentMin = diff;
            }
            prev = node.val;
            DFS(node.right);
            return currentMin;
        }
    }