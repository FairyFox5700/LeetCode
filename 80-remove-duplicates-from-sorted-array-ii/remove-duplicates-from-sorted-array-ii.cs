    public class Solution
    {
        //[1,1,1,2,2,3]
        public int RemoveDuplicates(int[] nums)
        {
            var first = nums[0];
            var counter = 1;
            var currentIndex = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == first)
                {
                    if (counter < 2)
                    {
                        Console.WriteLine(nums[i] + " " + counter);
                        currentIndex++;
                    }
                    counter++;
                }
                else
                {
                    counter = 1;
                    currentIndex++;
                }
                Console.WriteLine(currentIndex);
                   Console.WriteLine("first: " + first);
                      Console.WriteLine("nums: " + nums[i]);
                first = nums[i];
                nums[currentIndex] = nums[i];
            }
            return currentIndex + 1;
        }

    }