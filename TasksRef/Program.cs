int [] array = { 1, 2, 3, 4, 5 };
int size = int.Parse(Console.ReadLine());

static void Resize(ref int [] b, int newSize)
{
        b = new int [newSize];
}

Added(ref array, size);
AddedFirst(ref array);
AddedLast(ref array);
RemovedFirst(ref array);
RemovedLast(ref array);

static void Added(ref int[] b, int addedElement)
{
        int v = int.Parse(Console.ReadLine()); 
        b [v] = addedElement; 
}

static void AddedFirst(ref int[] b)
{
        int v = int.Parse(Console.ReadLine());
        b[0] = v;
}

static void AddedLast(ref int[] b)
{
        int v = int.Parse(Console.ReadLine());
        b[^1] = v;
}

static void RemovedFirst(ref int[] b)
{
        b[0] = 0;
}

static void RemovedLast(ref int[] b)
{
        b[^1] = 0;
}

Console.WriteLine(array.Length);
