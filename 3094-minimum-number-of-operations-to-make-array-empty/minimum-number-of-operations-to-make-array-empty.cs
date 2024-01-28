    public class Solution
    {
        public int MinOperations(int[] nums)
        {
            var hashMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!hashMap.ContainsKey(nums[i]))
                {
                    hashMap.Add(nums[i], 1);
                }
                else
                {
                    hashMap[nums[i]]++;
                }
            }


            var min = 0D;

            foreach (var (key, val) in hashMap)
            {
                if (val == 1)
                {
                    return -1;
                }
                min += Math.Ceiling((double)val / 3);
            }
            return (int)min;
        }
    }