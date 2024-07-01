    public class Solution
    {
        public int MinimumLevel(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            var min = long.MaxValue;
            var level = 1;
            var minLevel = -1;
            queue.Enqueue(root);
            while(queue.Count > 0)
            {
                var size = queue.Count;
                var levelSum = 0L;
                while(size > 0)
                {
                    var current = queue.Dequeue();
                    levelSum+=current.val;
                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                    if(current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }
                    size--;
                }
                
                if (levelSum < min)
                {
                    min = levelSum;
                    minLevel = level;
                }
                level++;
                
            }
            return minLevel;
        }
    }