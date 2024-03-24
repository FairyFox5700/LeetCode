    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if(nums1.Length > nums2.Length)
            {
                return FindMedianSortedArrays(nums2, nums1);
            }

            var len1 = nums1.Length;
            var len2 = nums2.Length;
            var left = 0;
            var right = len1;

            while (left <= right)
            {
                var partitionX = (left + right) / 2;
                var partitionY = (len1 + len2) / 2 - partitionX;

                var min1 = partitionX == 0 ? int.MinValue : nums1[partitionX - 1];
                var min2 = partitionY == 0 ? int.MinValue : nums2[partitionY - 1];
                var max1 = partitionX == len1 ? int.MaxValue : nums1[partitionX];
                var max2 = partitionY == len2 ? int.MaxValue : nums2[partitionY];

                if (min1 <= max2 && min2 <= max1)
                {
                    // correct partion, so get a mid element
                    if ((len1 + len2) % 2 == 0)
                    {
                        return (Math.Max(min1, min2) + Math.Min(max1, max2)) / 2.0;
                    }
                    else
                    {
                        return Math.Min(max1, max2);
                    }
                }
                else if (min1 >= max2)
                {
                    right = partitionX - 1; // it is in right part
                }
                else
                {
                    left = partitionX + 1; // it is in left part
                }
            }

            return 0;
        }
    }