    public class Solution
    {
        public int ArrangeCoins(int n)
        {
            var left = 0;
            var right = n;
            var result = 0;
            while (left<=right)
            {
                var mid = left + (right - left) / 2;
                  // Calculate the sum of the arithmetic progression
            long sum = ((long)mid * (mid + 1)) / 2;
               Console.WriteLine($"left = {left}, right = {right}, mid = {mid}, sum = {sum}");
               if(sum == n)
               {
                   return mid;
               }
                else if (sum < n)
                {
                    left = mid + 1;
                    
                }
                else
                {
                  
                    right = mid - 1;
                }
            }
            return right;
        }
    }