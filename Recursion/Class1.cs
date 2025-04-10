namespace Recursion;

public class Class1
{
    int[] array = { 1, 2, 3, 4, 5 };
    static void Recursive(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Recursive(array);
            Console.WriteLine(array[i]);
        }

    }
}
