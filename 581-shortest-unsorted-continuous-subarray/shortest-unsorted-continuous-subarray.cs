public class Solution {
    public int FindUnsortedSubarray(int[] nums)
    {
        var stack = new Stack<int>();
        var max = -1;
        var min = nums.Length;
        
        for (int i = 0; i < nums.Length; i++)
        {
            while (stack.Count > 0 && nums[stack.Peek()] > nums[i])
            {
                min = Math.Min(min, stack.Pop());
            }
            stack.Push(i);
        }
        
        stack.Clear();
        
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && nums[stack.Peek()] < nums[i])
            {
                max = Math.Max(max, stack.Pop());
            }
            stack.Push(i);
        }

        if (max == -1 || min == nums.Length)
            return 0;

        return max - min + 1;
    }
    
}