    public class Solution
    {
        public int GetMaxLen(int[] nums)
        {
            var negativeCount = 0;
            var positiveCount = 0;
            var maxLen = 0;
            for(int i= 0; i < nums.Length;i++)
            {
                if (nums[i] == 0)
                {
                    maxLen = Math.Max(maxLen, positiveCount);
                    positiveCount = 0;
                    negativeCount= 0;
                }
                else if(nums[i]>0)
                {
                    positiveCount++;
                    if(negativeCount==0)
                    {
                        negativeCount = 0;

                    }
                    else
                    {
                        negativeCount++; // any netative * postive el = negative el
                    }
                }
                else
                {
                    var temp = positiveCount;
                    if(negativeCount==0)
                    {
                        positiveCount = 0;
                    }
                    else
                    {
                        positiveCount = negativeCount+1; // any negative element was there and we found another negative el, now the sum is positive
                        // even if we encounter another negative element
                        // meaning it is 2nd el which is negative
                        // negative count was updated before, when set to temp
                    }
                    negativeCount = temp+1;
              
                }
                      maxLen = Math.Max(maxLen, positiveCount);
            }

            return maxLen;
    }
    }