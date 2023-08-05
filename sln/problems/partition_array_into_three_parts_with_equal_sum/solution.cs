    public class Solution
    {
        public bool CanThreePartsEqualSum(int[] arr)
        {
            var sume = arr.Sum();
            if (sume % 3 != 0)
            {
                return false;
            }
            var sumOfPartition = sume / 3;
            var partiotionCount = 0;
            var totalSum = 0;
            foreach (var ar in arr)
            {
                totalSum += ar;
                if (totalSum == sumOfPartition)
                {
                    partiotionCount++;
                    totalSum = 0;
                }
            }
            return partiotionCount >= 3;
        }
    }