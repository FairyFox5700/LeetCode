    public class Solution
    {
        public string RemoveDuplicateLetters(string s)
        {
            var listOfOccurr = new int[26];
            var visited = new bool[26];
            var stack = new Stack<char>();
            var result = new StringBuilder();
            foreach (var ch in s)
            {
                var index  = ch - 'a';
                listOfOccurr[index]++;
            }

            foreach (var ch in s)
            {
                var index  = ch - 'a';
                listOfOccurr[index]--;
                if (visited[index])
                    continue;

                while (stack.Count > 0 && stack.Peek() > ch && listOfOccurr[stack.Peek() - 'a'] !=0)
                {
                    var indexLocal = stack.Peek() - 'a';
                    Console.WriteLine(stack.Peek());
                    visited[indexLocal] = false;
                    stack.Pop();
                }
                stack.Push(ch);
                visited[index] = true;
                Console.WriteLine(ch + " " + listOfOccurr[index].ToString());    
                Console.WriteLine(stack.Peek());
                Console.WriteLine(stack.Peek() > ch);
            }

            for (int i = stack.Count - 1; i >= 0; i--)
            {
                result.Insert(0, stack.Pop());
            }

            return result.ToString();
        }
    }