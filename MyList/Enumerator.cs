using System.Collections;

public class Enumerator : IEnumerator<int>
{
    private readonly int _start;
    private readonly int _count;
    private int _currentIndex;

    public Enumerator(int start, int count)
    {
        _start = start;
        _count = count;
        _currentIndex = -1;
    }

    public bool MoveNext()
    {
        if (_currentIndex + 1 < _count)
        {
            _currentIndex++;
            return true;
        }

        return false;
    }

    public void Reset()
    {
        _currentIndex = -1;
    }

    object? IEnumerator.Current => Current;

    public int Current
    {
        get { return _start + _currentIndex; }
    }
    
    public void Dispose()
    {
    }
}