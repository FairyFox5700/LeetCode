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
        public int[] FindMode(TreeNode root)
        {
            var currentNum = root.val;
            var currentMax = 0;
            var totalMax = 0;
            var answers = new List<int>();
            InOrder(root, ref currentNum, ref currentMax, ref totalMax, ref answers);

            return answers.ToArray();
        }

        private void InOrder(TreeNode node, ref int currentNum, ref int currentmax, ref int totalMax, ref List<int> answers)
        {
            if (node == null)
            {
                return;
            }

            InOrder(node.left, ref currentNum, ref currentmax, ref totalMax, ref answers);
            if (currentNum == node.val)
            {
                currentmax++;
            }
            else
            {
                currentNum = node.val;
                currentmax = 1;
            }

            if (currentmax > totalMax)
            {
                answers.Clear();
                totalMax = currentmax;
            }

            if (currentmax == totalMax)
            {
                answers.Add(node.val);
            }

            InOrder(node.right, ref currentNum, ref currentmax, ref totalMax, ref answers);
        }
    }