public class Solution
{
    public int AmountOfTime(TreeNode root, int start)
    {
        var graph = BuildGraph(root);
        var visited = new HashSet<int>();
        var queue = new Queue<int>();

        var time = 0;
        queue.Enqueue(start);
        visited.Add(start); // Mark the start node as visited
        while (queue.Count > 0)
        {
            var levelSize = queue.Count;
            for (int i = 0; i < levelSize; i++)
            {
                var current = queue.Dequeue();
                foreach (var neighbor in graph[current])
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor); // Mark neighbor as visited here
                    }
                }
            }
            time++;
        }

        return time - 1;
    }

    private Dictionary<int, List<int>> BuildGraph(TreeNode root)
    {
        var graph = new Dictionary<int, List<int>>();
        if (root == null)
        {
            return graph;
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (!graph.ContainsKey(node.val))
            {
                graph[node.val] = new List<int>();
            }

            if (node.left != null)
            {
                graph[node.val].Add(node.left.val);
                if (!graph.ContainsKey(node.left.val))
                {
                    graph[node.left.val] = new List<int>();
                }
                graph[node.left.val].Add(node.val);
                queue.Enqueue(node.left);
            }

            if (node.right != null)
            {
                graph[node.val].Add(node.right.val);
                if (!graph.ContainsKey(node.right.val))
                {
                    graph[node.right.val] = new List<int>();
                }
                graph[node.right.val].Add(node.val);
                queue.Enqueue(node.right);
            }
        }

        return graph;
    }
}
