public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        var result = new List<IList<int>>();
        var currentList = new List<int>();
        Backtracking(currentList, target, 0, candidates, result);
        return result;
    }

    public void Backtracking(List<int> currentList, int target, int startIndex, int[] candidates,
        List<IList<int>> result)
    {
     
        if (target == 0)
        {
            result.Add(new List<int>(currentList));
            Console.WriteLine($"// Added combination: [{string.Join(",", currentList)}]");
            return;
        }

        if (target < 0)
        {
            return;
        }

        for (int i = startIndex; i < candidates.Length; i++)
        {
            currentList.Add(candidates[i]);
           // Console.WriteLine($"// backtracking({string.Join(",", currentList)}, {target - candidates[i]}, {i + 1}, [{string.Join(",", candidates)}], result)");
            Backtracking(currentList, target - candidates[i], i, candidates, result);

            // backtrack to previous after reaching the end of the chain
            currentList.Remove(candidates[i]);
        }
    }
}
