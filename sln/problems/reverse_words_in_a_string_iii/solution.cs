    public class Solution
    {
        public string ReverseWords(string s)
        {
            var sArray = s.Split(' ');
            var sb = new StringBuilder();
            foreach (var el in sArray)
            {
                var left = 0;
               var right = el.Length - 1;
               var current = el.ToCharArray();
               while (left<right)
               {
                    (current[left], current[right]) = (current[right], current[left]);
                    left++;
                    right--;
               }

               sb.Append(new string(current));
               sb.Append(" ");
            }
            return sb.Remove(sb.Length-1,1).ToString();
        }
    }