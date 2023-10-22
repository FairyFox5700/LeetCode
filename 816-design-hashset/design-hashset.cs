public class MyHashSet
{
    private LinkedList<int>[] _buckets;
    private const int primeNumber = 444;

    public MyHashSet()
    {
        _buckets = new LinkedList<int>[primeNumber];
        for (int i = 0; i < primeNumber; i++)
        {
            _buckets[i] = new LinkedList<int>();
        }
    }

    private int HashCode(int key)
    {
        return key % primeNumber; 
    }

    public void Add(int key)
    {
        var index = HashCode(key);
        if (!_buckets[index].Contains(key))
        {
            _buckets[index].AddLast(key);
        }
    }

    public void Remove(int key)
    {
        var index = HashCode(key);
        _buckets[index].Remove(key);
    }

    public bool Contains(int key)
    {
        var index = HashCode(key);
        return _buckets[index].Contains(key);
    }
}
