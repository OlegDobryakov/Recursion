void PrintArray(int[] array, int size)
{
    if(size < 0)
    {
        return;
    }
    Console.Write($"{array[size]} ");
    PrintArray(array, size - 1);
}


int[] array = {1, 2, 5, 0, 10, 34};
int size = 0;
for (int i = 0; i < array.Length; i++)
{
    size++;
}
PrintArray(array, size - 1);