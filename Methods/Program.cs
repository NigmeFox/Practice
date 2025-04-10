int arr = int.Parse(Console.ReadLine());
int [] arr2 = new int[arr];
for (int q = 0; q < arr2.Length; q++)
{
    arr2[q] = int.Parse(Console.ReadLine());
}
int i = int.Parse(Console.ReadLine());
int result = Search(arr2, i);
Console.WriteLine(result);

static int Search(int[] array, int search)
{
    int result = -1;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] == search)
        {
            return j;
        }
    }
    return result;
}

