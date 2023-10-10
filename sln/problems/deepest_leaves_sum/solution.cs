    public class Solution
    {
        public int DeepestLeavesSum(TreeNode root)
        {
            int sum = 0;
            int deepestLevel = 0;
            LeavesSum(root, ref sum, ref deepestLevel);

            return sum;
        }

        private void LeavesSum(TreeNode node, ref int sum, ref int deepestLevel)
        {
            //1. level order traversal
            //2. sum the last level
            // second one is level
            var queue = new Queue<(TreeNode, int)>();

            queue.Enqueue((node, 0));

            while (queue.Count > 0)
            {
                var size = queue.Count;
                while (size > 0)
                {
                    var (el, level) = queue.Dequeue();
                    if (el.left == null && el.right == null && deepestLevel==level)
                    {
                        sum += el.val;
                    }
                    else if (el.left == null && el.right == null && deepestLevel < level)
                    {
                        sum = el.val;
                        deepestLevel = level;
                    }
                    if (el.left != null)
                    {
                        queue.Enqueue((el.left, level+1));
                    }

                    if (el.right != null)
                    {
                        queue.Enqueue((el.right, level+1));
                    }
                    size--;
                }
            }
        }
    }