    public class Solution
    {
        public int SubarraysDivByK(int[] nums, int k)
        {
            var hashMap = new Dictionary<int, int>();
            var totalSum = 0;
            var result = 0;
            hashMap.Add(0,1);
            for (int i = 0;i<nums.Length; i++)
            {
                totalSum += nums[i];
                var divisionResult = totalSum % k;
                while(divisionResult < 0)
                {
                    ////https://math.stackexchange.com/questions/2179579/how-can-i-find-a-mod-with-negative-number
                    divisionResult+=k;
                }
                if(hashMap.ContainsKey(divisionResult))
                {
                    result += hashMap[divisionResult];
                    hashMap[divisionResult]++;
                }
                else
                {
                    hashMap.Add(divisionResult, 1);
                }
            }



            return result;
        }
    }