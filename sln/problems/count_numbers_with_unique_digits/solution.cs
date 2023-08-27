   public class Solution
    {
        public int CountNumbersWithUniqueDigits(int n)
        {
            int sum = 10; // contains 10 as initial sum
            var product = 9; // initial product is 9, because we can't have 0 as the first digit
            if (n == 0)
            {
                return 1;
            }
            var nextAvailableNumberOfCharacter = 9;
            for (int i = 1; i < n; i++)
            {
                if(nextAvailableNumberOfCharacter>0)
                {
                    product *= nextAvailableNumberOfCharacter;
                    sum += product;
                    nextAvailableNumberOfCharacter--;
                }
            }

            return sum;
        }
    }
