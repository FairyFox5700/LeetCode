public class Solution {
            public void Merge(int[] nums1, int m, int[] nums2, int n)
            {
                var end = nums1.Count() -1;
                var min = Math.Min(m, n);
                var firstIndex = m - 1;
                var secondIndex = n - 1;
                while(firstIndex >= 0 && secondIndex>=0)
                {
                    if(nums1[firstIndex] >= nums2[secondIndex])
                    {
                        nums1[end] = nums1[firstIndex];
                        firstIndex--;
                    }
                    else
                    {
                        nums1[end] = nums2[secondIndex];
                        secondIndex--;
                    }
                    end--;
                }

                while (firstIndex >= 0)
                {
                    nums1[end] = nums1[firstIndex];
                    firstIndex--; 
                    end--;
                }
                while (secondIndex >= 0)
                {
                    nums1[end] = nums2[secondIndex];
                    secondIndex--;
                    end--;
                }
            }
}