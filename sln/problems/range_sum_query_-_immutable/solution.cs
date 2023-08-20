    public class NumArray
    {
        private int[] _sumNums;

        public NumArray(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }
            _sumNums= nums;

        }

        public int SumRange(int left, int right)
        {
            var leftIndexToSubstract = left - 1;
            if (leftIndexToSubstract < 0)
            {
                return _sumNums[right];
            }
            else
            {
                return _sumNums[right] - _sumNums[leftIndexToSubstract];
            }
        }
    }

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */