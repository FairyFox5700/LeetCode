    public class Solution
    {
        public int SumRootToLeaf(TreeNode root)
        {
            var stack = new Stack<(TreeNode, int)>();
            if (root == null)
            {
                return 0;
            }

            var sum = 0;
            stack.Push((root, 0));
            while (stack.Count > 0)
            {
                var pop = stack.Pop();

                //currentVal << 1 means pow 2, so we shift the sign
                var currentVal = (pop.Item2 << 1) | pop.Item1.val;
                Console.WriteLine(currentVal);
                Console.WriteLine(currentVal << 1);
                if (pop.Item1.left == null && pop.Item1.right == null)
                {
                    sum += currentVal;
                }

                if (pop.Item1.left != null)
                {
                    stack.Push((pop.Item1.left, currentVal));
                }

                if (pop.Item1.right != null)
                {
                    stack.Push((pop.Item1.right, currentVal));
                }
            }

            return sum;
        }
    }