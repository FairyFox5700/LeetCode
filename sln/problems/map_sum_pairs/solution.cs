    public class MapSum
    {
        public class TrieNode
        {
            public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
            public bool EndOfTheWorld;
            public int Value;
        }

        public TrieNode Root = new TrieNode();

        public Dictionary<string, int> WordsCache = new Dictionary<string, int>();
        public MapSum()
        {

        }

        public void Insert(string key, int val)
        {
            var current = Root;
            Console.WriteLine("Inserting key: " + key + " with value: " + val);
            var diff = 0;
            if (!WordsCache.ContainsKey(key))
            {
                WordsCache.Add(key, val);
                diff = 0;
            }
            else
            {
                diff = WordsCache[key];
                WordsCache[key] = val;
            }
            current.Value = val -diff;
            foreach (var ch in key)
            {
                Console.WriteLine("Processing character: " + ch);

                if (!current.Children.ContainsKey(ch))
                {
                    var newNode = new TrieNode()
                    {
                        Value = val,
                    };
                    current.Children.Add(ch, newNode);
                    current = newNode;
                    Console.WriteLine("Character '" + ch + "' does not exist. Creating a new node with Value: " + val);
                }
                else
                {
                    current = current.Children[ch];
                    //rewrite
                    current.Value += (val -diff);
                    Console.WriteLine("Character '" + ch + "' already exists. Updating its Value to: " + current.Value);
                }
            }
        }

        public int Sum(string prefix)
        {
            var current = Root;
            Console.WriteLine("Searching for prefix: " + prefix);

            // Search in the trie
            foreach (var ch in prefix)
            {
                Console.WriteLine("Processing character: " + ch);

                if (current.Children.ContainsKey(ch))
                {
                    current = current.Children[ch];
                }
                else
                {
                    Console.WriteLine("Character '" + ch + "' not found. Returning 0.");
                    return 0;
                }
            }

            Console.WriteLine("Prefix found. Sum: " + current.Value);
            return current.Value;
        }

    }