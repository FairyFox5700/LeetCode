public class Solution {
        public void SortColors(int[] nums)
        {
            int r, w, b;
            r = w = b = 0;

            foreach (var t in nums)
            {
                if (t == 0)
                {
                    r++;
                }
                if (t == 1)
                {
                    w++;
                }
                if (t == 2)
                {
                    b++;
                }
            }

for (var i = 0; i < nums.Length; i++)
        {
            if(r > 0)
            {
                nums[i] = 0;
                r--;
            }
            else if(w > 0)
            {
                nums[i] = 1;
                w--;
            }
            else
                nums[i] = 2;
        }
        }
}