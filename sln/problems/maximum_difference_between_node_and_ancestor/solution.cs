    public class Solution
    {
        public int MaxAncestorDiff(TreeNode root)
        {
            var currentMax = int.MinValue;
            var currentMin = int.MaxValue;
            return  DFS(root, currentMin, currentMax);
        }

        private int DFS(TreeNode node, int currMin,  int currMax)
        {
            if (node == null)
            {
                return currMax - currMin;
            }

            currMax = Math.Max(currMax, node.val);
            currMin = Math.Min(currMin, node.val);

            var leftChild = DFS(node.left, currMin,  currMax);
            var rightChild = DFS(node.right, currMin, currMax);

            return Math.Max(leftChild, rightChild);
        }
    }