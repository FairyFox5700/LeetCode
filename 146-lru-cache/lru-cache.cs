public class DoubleLLNode
{
    public int Key { get; set; }
    public int Value { get; set; }
    public DoubleLLNode Next { get; set; }
    public DoubleLLNode Prev { get; set; }
}

public class DoubleLinkedList
{
    public DoubleLLNode Root = new DoubleLLNode();
    public DoubleLLNode Tail = new DoubleLLNode();

    public DoubleLinkedList()
    {
        Root.Next = Tail;
        Tail.Prev = Root;
    }

    public void InsertLast(int key, int value)
    {
        var newNode = new DoubleLLNode()
        {
            Key = key,
            Value = value,
            Prev = Tail.Prev,
            Next = Tail
        };
        Tail.Prev.Next = newNode;
        Tail.Prev = newNode;
    }

    public DoubleLLNode AddFirst(int key, int value)
    {
        var newNode = new DoubleLLNode()
        {
            Key = key,
            Value = value,
            Next = Root.Next,
            Prev = Root
        };
        Root.Next.Prev = newNode;
        Root.Next = newNode;
        return newNode;
    }

    public void Remove(DoubleLLNode node)
    {
        node.Prev.Next = node.Next;
        node.Next.Prev = node.Prev;
    }
}

public class LRUCache
{
    private DoubleLinkedList DoublyLinkedList = new DoubleLinkedList();
    private Dictionary<int, DoubleLLNode> cache = new Dictionary<int, DoubleLLNode>();
    private int capacity;

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
    }

    public int Get(int key)
    {
        if (cache.ContainsKey(key))
        {
            var node = cache[key];
            DoublyLinkedList.Remove(node);
            var newNode = DoublyLinkedList.AddFirst(node.Key, node.Value);
            cache[key] = newNode; // Update the cache with the new node
            return node.Value;
        }
        return -1;
    }

    public void Put(int key, int value)
    {
        if (cache.ContainsKey(key))
        {
            var node = cache[key];
            DoublyLinkedList.Remove(node);
        }
        else if (cache.Count == capacity)
        {
            var last = DoublyLinkedList.Tail.Prev;
            DoublyLinkedList.Remove(last);
            cache.Remove(last.Key);
        }
        var newNode = DoublyLinkedList.AddFirst(key, value);
        cache[key] = newNode;
    }
}
