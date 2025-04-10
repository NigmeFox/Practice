using System.Collections;

public class MyList : IEnumerable<int>
{
    private readonly int _start;
    private readonly int _count;

    public MyList(int start, int count)
    {
        _start = start;
        _count = count;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return new Enumerator(_start, _count);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}