public class Node
{
    public int Key;
    public int Value;
}

public class LRUCache
{
    private int capacity;
    private LinkedList<Node> cache;
    private Dictionary<int, LinkedListNode<Node>> keyValuePairs;

    public LRUCache(int capacity)
    {
        if (capacity <= 0)
        {
            throw new ArgumentException(nameof(capacity));
        }

        this.capacity = capacity;
        cache = new();
        keyValuePairs = new();
    }

    public int Get(int key)
    {
        if (!keyValuePairs.ContainsKey(key))
        {
            return -1;
        }

        // add the node to the end of list
        var node = keyValuePairs[key];
        cache.Remove(node);
        cache.AddLast(node);

        return node.Value.Value;
    }

    public void Put(int key, int value)
    {
        if (!keyValuePairs.ContainsKey(key)) // no such node in the list
        {
            var newNode = new Node()
            {
                Key = key,
                Value = value
            };

            // add the node
            var added = cache.AddLast(newNode);
            keyValuePairs.Add(key, added);
        }
        else // node already in the last, update its value
        {
            var node = keyValuePairs[key];
            node.Value.Value = value;

            cache.Remove(node);
            cache.AddLast(node);
        }

        // if capacity is exceeded, remove the first element from the list
        if (cache.Count > capacity)
        {
            var first = cache.First();
            cache.Remove(first);
            keyValuePairs.Remove(first.Key);
        }
    }
}