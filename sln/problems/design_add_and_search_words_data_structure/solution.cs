    public class TrieNode
    {
        public char Value = ' ';
        public bool IsEndOfWord = false;
        public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
        public TrieNode(char val)
        {
            Value = val;
        }
    }
    public class WordDictionary
    {
        private TrieNode root = new TrieNode(' ');
        public WordDictionary()
        {

        }

        public void AddWord(string word)
        {
            var current = root;
            foreach (var w in word)
            {
                if (!current.Children.ContainsKey(w))
                {
                    var newNode = new TrieNode(w);
                    current.Children.Add(w, newNode);
                    current = newNode;
                }
                else
                {
                    current = current.Children[w];
                }
            }

            current.IsEndOfWord = true;
        }

        private bool DFS(TrieNode node, string word)
        {
            var root = node;
            
            for(int i=0;i<word.Length;i++)
            {
                var w = word[i];
                if (w == '.')
                {
                    // skip this char for any possible child node
                    foreach (var child in root.Children)
                    {
                        if (word.Length < 1)
                        {
                            return root.IsEndOfWord;
                        }

                        if(DFS(child.Value, word.Substring(1+i)))
                        {
                            return true;
                        }
                    }
                    return false;
                }
                else if (root.Children.ContainsKey(w))
                {
                    root = root.Children[w];
                }
                else
                {
                    return false;
                }
            }
            return root.IsEndOfWord;
        }

        public bool Search(string word)
        {
            return DFS(root, word);
        }
    }

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */