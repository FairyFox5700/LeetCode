public class FileSystem
{
    private readonly TrieNode _root;

    public FileSystem()
    {
        _root = new TrieNode();
    }

    public bool CreatePath(string path, int value)
    {
        var pathArray = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
        var current = _root;

        for (int i = 0; i < pathArray.Length; i++)
        {
            var part = pathArray[i];

            // If the part does not exist and it's not the last part, return false
            if (!current.Children.ContainsKey(part))
            {
                if (i != pathArray.Length - 1)
                {
                    return false;
                }

                // Create a new node
                var node = new TrieNode
                {
                    Character = part,
                    Value = value
                };
                current.Children.Add(part, node);
                current = node;
            }
            else
            {
                current = current.Children[part];
            }
        }

        // Check if the path already exists as a word
        if (current.IsWord)
        {
            return false;
        }

        // Mark the end of the path and set the value
        current.IsWord = true;
        current.Value = value;

        return true;
    }

    public int Get(string path)
    {
        var pathArray = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
        var current = _root;

        foreach (var part in pathArray)
        {
            if (current.Children.ContainsKey(part))
            {
                current = current.Children[part];
            }
            else
            {
                return -1;
            }
        }

        return current.IsWord ? current.Value : -1;
    }
}

public class TrieNode
{
    public Dictionary<string, TrieNode> Children = new();
    public bool IsWord { get; set; }
    public int Value { get; set; }
    public string Character { get; set; }
}

/**
 * Your FileSystem object will be instantiated and called as such:
 * FileSystem obj = new FileSystem();
 * bool param_1 = obj.CreatePath(path,value);
 * int param_2 = obj.Get(path);
 */
