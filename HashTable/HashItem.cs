public class HashItem
{
    public string Key { get; set; }
    public string Value { get; set; }

    public HashItem(string key, string value)
    {
        this.Key = key;
        this.Value = value;
    }
}