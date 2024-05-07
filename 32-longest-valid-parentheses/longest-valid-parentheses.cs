public class Solution
{
    public int LongestValidParentheses(string s)
    {

        // two flow
        // 1. left to right
        var maxCount = 0;
        var leftCount = 0;
        var rightCount = 0;
        for(int i = 0; i< s.Length; i++)
        {
            if (s[i] == '(')
            {
                leftCount++;
            }
            else
            {
                rightCount++;
            }

            if(leftCount == rightCount)
            {
                maxCount = Math.Max(maxCount, leftCount + rightCount);
            }
            else if (rightCount > leftCount) {
                leftCount = rightCount = 0;
            }
        }

        leftCount = 0;
        rightCount = 0;
        // 2. right to left

        for(int i =s.Length - 1; i >= 0; i--)
        {
            if (s[i] == '(')
            {
                leftCount++;
            }
            else
            {
                rightCount++;
            }
            if (leftCount == rightCount)
            {
                maxCount = Math.Max(maxCount, leftCount + rightCount);
            }
            else if (leftCount > rightCount) {
                leftCount = rightCount = 0;
            }
            
        }

        return maxCount;

    }
}