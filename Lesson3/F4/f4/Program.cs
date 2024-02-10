int FindPrimeNumbers(int[] arr)
{ int a = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 > 0)
        {
            a = a + 1;
        }
    } 
    int result = a;
    return result;
}
int[] array = [2, 6, 3, 7, 2, 19, 53, 23, 54, 724924, 13];
int result = FindPrimeNumbers(array);
Console.WriteLine(result);