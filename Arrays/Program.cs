int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < arr.Length ; i++)
{
    int s = int.Parse(Console.ReadLine());
    arr[i] = s;
}
Console.WriteLine(string.Join(" ", arr));

int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        sum += arr[i];
    }
}
Console.WriteLine(sum);

int min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
    }
}
Console.WriteLine(min);


