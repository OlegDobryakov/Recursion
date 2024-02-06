int[] array = { 1, 6, 3, 10, 4, 9, 5, 5, 9, 5, 7, 939, 5, 21};
int i = 0;
int size = 0;
int j = 0;
int n = 0;
while (j < array.Length)
{
    j++;
}
j--;
while (i < j)
{
    array[n] = array[i] * array[j];
    n++;
    i++;
    j--;
    size++;

    if (i == j)
    {
        n++;
        Console.WriteLine($"Нету {n} пары.");
    }

}
for (n = 0; n < size; n++)
{
    Console.Write(array[n] + " ");
}

