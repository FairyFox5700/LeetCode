    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            var reversed = 0;
            var temp = x;
            while (temp > 0)
            {
                var div = temp / 10;
                var rem = temp % 10;
                reversed = reversed * 10 + rem; // the first reminder will be the first digit
                // then every next reminder will be added to the end of the reversed number ( by multiplying previous reversed number by 10)
                temp = temp /10;
            }

            return reversed == x;
        }
    }