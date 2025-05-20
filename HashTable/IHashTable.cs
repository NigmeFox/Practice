interface IHashTable
{
    void Add(string key, string value);
    int GetIndex(string key);
    void Remove(string key);
    string? Get(string key);
}