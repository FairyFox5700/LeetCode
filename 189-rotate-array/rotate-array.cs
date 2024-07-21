
public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        var n = nums.Length;
        k = k % n;
        int start = 0;
        int numberOfEllementsPlacedInCorrectPosition = 0;
        while(numberOfEllementsPlacedInCorrectPosition< n)
        {
            int current = start;
            var prev = nums[current];
            do
            {
                var newIndex = (current + k) % n;
                var next = nums[newIndex];
                nums[newIndex] = prev;
                prev = next;
                current = newIndex;
                numberOfEllementsPlacedInCorrectPosition++;
            }
            while(start!=current);
            start++;
           
        }
    }
}