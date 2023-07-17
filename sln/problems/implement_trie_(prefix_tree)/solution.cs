  public class TrieNode
    {
        public char Character = ' ';
        public bool EndoftheWord = false;
        public Dictionary<char, TrieNode> Childs = new Dictionary<char, TrieNode>();
        public TrieNode(char character)
        {
            Character = character;
        }

    }

    public class Trie
    {
        private TrieNode root = new TrieNode(' ');
        // https://www.youtube.com/watch?v=oobqoCJlHA0&ab_channel=NeetCode
        public Trie()
        {

        }

        public void Insert(string word)
        {
            var current = root;
            foreach (var ch in word)
            {
                if(current.Childs.ContainsKey(ch))
                {
                    current = current.Childs[ch];
                }else
                {
                    var newNode = new TrieNode(ch);
                    current.Childs.Add(ch, newNode);
                    current = newNode;
                }
            }
            current.EndoftheWord = true;
        }

        public bool Search(string word)
        {
            var current = root;
            var chars = word.ToCharArray();
            foreach (var ch in chars)
            {
                if (current.Childs.ContainsKey(ch))
                {
                    current = current.Childs[ch];
                }
                else
                {
                    return false;
                }
            }
            return current.EndoftheWord;
        }

        public bool StartsWith(string prefix)
        {
            var current = root;
            var chars = prefix.ToCharArray();
            foreach (var ch in chars)
            {
                if (current.Childs.ContainsKey(ch))
                {
                    current = current.Childs[ch];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */