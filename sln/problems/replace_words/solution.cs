
    /*public class Solution
    {
        // using Tries
        public class TrieNode
        {
            public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
            public bool EndOfTheWorld;
            public string Word;
        }

        private TrieNode Root = new TrieNode();

        public void Insert(string word)
        {
            var current = Root;
            foreach (var ch in word)
            {
                if (!current.Children.ContainsKey(ch))
                {
                    current.Children.Add(ch, new TrieNode());
                }
                current = current.Children[ch];
            }
            current.EndOfTheWorld = true;
            current.Word = word;
        }

        public string ReplaceWords(IList<string> dictionary, string sentence)
        {
            foreach (var prefix in dictionary)
            {
                Insert(prefix);
            }

            var words = sentence.Split(' ');
            var answer = new StringBuilder();
            
            foreach (var word in words)
            {
                var current = Root;
                foreach (var ch in word)
                {
                    if (current.Children.ContainsKey(ch))
                    {
                        current = current.Children[ch];
                        if (current.EndOfTheWorld)
                        {
                            answer.Append(current.Word);
                            break;
                        }
                    }
                    else
                    {
                        answer.Append(word);
                        break;
                    }
                }
                answer.Append(" ");
            }
            return answer.Remove(answer.Length - 1, 1).ToString();
        }
    }
    */

        public class Solution
    {
        //space: O(n)
        // Complexity: O(words*max(word.Length)*max(word.Leght) --substring operation)
        public string ReplaceWords(IList<string> dictionary, string sentence)
        {
            // basically meant to get the shortest prefix
            // sort the dictionary
            var set = new HashSet<string>();
            foreach (var str in dictionary)
            {
                set.Add(str);
            }
            // ["cat","bat","rat"]
            var words = sentence.Split(' ');
            var answer = new StringBuilder();
            foreach (var word in words)
            {
                var prefix = "";
                for (int i = 0; i < word.Length; i++)
                {
                    var subString = word.Substring(0, i + 1);
                    if (set.Contains(subString))
                    {
                        prefix = subString;
                        break;
                    }
                }
                if (prefix == string.Empty)
                {
                    prefix = word;
                }
                // if the word not found
                answer.Append(prefix);
                answer.Append(" ");
            }
            return answer.Remove(answer.Length - 1, 1).ToString();
        }
    }