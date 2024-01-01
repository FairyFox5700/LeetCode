public class Solution {
    public void ReverseWords(char[] s) {
        var left = 0;
        var right = 0;
  Reverse(s, left, s.Count()-1);
        while(right<s.Count())
        {
            for(int i =left; i<s.Count(); i++)
            {
                if(s[i]!= ' ')
                {
                    right=i;
                }
                else 
                {
                    break;
                }
            }
        Reverse(s, left, right);
        left = right+2;
        right = left+1;
        }
    }

    private void Reverse(char[] s, int left, int right)
    {
        while(left<right)
        {
            (s[left], s[right]) = (s[right], s[left]);
            left++;
            right--;
        }

    }
}