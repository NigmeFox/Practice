
int[] array = { 1, 2, 0, 4, 5 };

int sumArray = 0;

Recursive(array,0, sumArray);

static void Recursive(int[] array, int index, int sum)
{

    Console.WriteLine(array[index]);
    sum += array[index];
    index++;
    if (array.Length == index)
    {
        Console.WriteLine(sum);
        return;
    }
    Recursive(array, index, sum);
}


