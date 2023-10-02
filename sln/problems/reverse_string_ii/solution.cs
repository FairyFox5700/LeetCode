    public class Solution
    {
        public string ReverseStr(string s, int k)
        {
            var reverse = s.ToCharArray();
            for (int i = 0; i < reverse.Length; i +=2* k)
            {
                var left = i;
                var right = i + k - 1;
                if(right >= s.Length)
                {
                    right = s.Length -1;
                }
                while (left<right)
                {
                    (reverse[left], reverse[right]) = (reverse[right], reverse[left]);
                    left++;
                    right--;
                }
            }

            return new string(reverse);
        }
    }