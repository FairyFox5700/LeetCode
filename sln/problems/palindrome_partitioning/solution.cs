public class Solution {
        public IList<IList<string>> Partition(string s)
        {
            //aab
            var result = new List<IList<string>>();
            var current = new List<string>();
            DFS(0, s, current, result);

            return result;
        }

          private void DFS(int start, string s, IList<string> current, IList<IList<string>> result)
    {
        if (start >= s.Length)
        {
            result.Add(new List<string>(current));
            return;
        }

        for (int i = start; i < s.Length; i++)        {
            Console.WriteLine($"Checking substring from {start} to {i}: {s.Substring(start, i-start+ 1)}");
            
            if (IsPalindrome(s, start, i))
            {
                var currentString = s.Substring(start, i-start + 1);
                current.Add(currentString);
                Console.WriteLine($"Found palindrome: {currentString}");
                Console.WriteLine($"Current array: [{string.Join(", ", current)}]");
                DFS(i + 1, s, current, result);
                current.RemoveAt(current.Count - 1);
                Console.WriteLine($"Backtracked, current array: [{string.Join(", ", current)}]");
            }
        }
    }
 private bool IsPalindrome(string s, int start, int end)
    {
        while (start < end)
        {
            if (s[start] != s[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
  
}