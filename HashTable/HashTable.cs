public class HashTable : IHashTable
{   
    private const int Size = 10;
    private List<HashItem>[] buckets;

    public HashTable()
    {
        buckets = new List<HashItem>[Size];
        for (int i = 0; i < Size; i++)
        {
            buckets[i] = new List<HashItem>();
        }
    }

    public string? Get(string key)
    {
        int index = GetIndex(key);

        foreach (var item in buckets[index])
        {
            if (item.Key == key)
            {
                return item.Value;
            }
        }
        return null;
    }
    
    public void Add(string key, string value)
    {
        int index = GetIndex(key);
        foreach (var item in buckets[index])
        {
            if (item.Key == key)
            {
                item.Value = value;
                return;
            }
        }
        buckets[index].Add(new HashItem(key, value));
    }

    public int GetIndex(string key)
    {
        int hash = key.GetHashCode();
        return Math.Abs(hash % Size);
    }

    public void Remove(string key)
    {
        int index = GetIndex(key);
        for (int i = 0; i < buckets.Length; i++)
        {
            if (buckets[index].Any(x => x.Key == key))
            {
                buckets[i].Remove(buckets[index].First(x => x.Key == key));
            }
        }
    }
}