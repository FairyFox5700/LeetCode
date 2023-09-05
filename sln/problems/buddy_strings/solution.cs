    public class Solution
    {
        public bool BuddyStrings(string s, string goal)
        {
           //1. case when length are different
           if(s.Length != goal.Length)
               return false;
           // 2. case when strings are equal
           // any swap of non equal characters will not make them equal
           if (s.Equals(goal))
           {
               var dict = new Dictionary<char, int>();
               foreach (var ch in s)
               {
                   if(!dict.ContainsKey(ch))
                       dict.Add(ch, 1);
                   else
                        dict[ch]++;
               }
               return dict.Values.Any(e => e > 1);
           }

           // 3. when they are not equal
           // we allowed to do only one swap
           var first = -1;
           var second = -1;
           for (int i = 0; i < s.Length; i++)
           {
               if (s[i] != goal[i])
               {
                   if (first == -1)
                   {
                       first = i;
                   }
                   else if (second == -1)
                   {
                       second = i;
                   }
                   else
                   {
                       return false;
                   }
               }
           }

           return (second != -1 && s[first] == goal[second] && s[second] == goal[first]);
        }
    }