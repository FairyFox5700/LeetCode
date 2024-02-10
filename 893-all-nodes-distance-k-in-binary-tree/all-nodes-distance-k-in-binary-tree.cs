public class Solution
{
    public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
    {
        var dict = new Dictionary<int, List<TreeNode>>();
        BuildGraph(dict, root);

        // find with graph algorithm node of distnace k
        // dfs

        var visited = new HashSet<int>();
         var result = new List<int>();
        DFS(dict, target, visited, 0, result, k);

        return result;


    }


    private void DFS(Dictionary<int, List<TreeNode>> dict, TreeNode root, HashSet<int> visited, int distance, List<int> result, int target)
    {
        if (root == null)
        {
            return; // return condition
        }
 
        visited.Add(root.val);
        if (distance == target)
        {
            result.Add(root.val);
        }

        foreach (var neighbour in dict[root.val])
        {
    if (!visited.Contains( neighbour.val))
        {

           
            DFS(dict, neighbour, visited, distance +1, result, target);
        }
        }
    }

    private void BuildGraph(Dictionary<int, List<TreeNode>> dict, TreeNode root)
    {
        if (root == null)
            return;

         if (!dict.ContainsKey(root.val))
                dict[root.val] = new List<TreeNode>();

        if (root.left != null)
        {
            if (!dict.ContainsKey(root.left.val))
            {
                dict[root.left.val] = new List<TreeNode>();
            }

            dict[root.left.val].Add(root);
            dict[root.val].Add(root.left);
        }

        if (root.right != null)
        {
            if (!dict.ContainsKey(root.right.val))
            {
                dict[root.right.val] = new List<TreeNode>();
            }

            dict[root.right.val].Add(root);
            dict[root.val].Add(root.right);
        }

        BuildGraph(dict, root.left);
        BuildGraph(dict, root.right);
    }
}