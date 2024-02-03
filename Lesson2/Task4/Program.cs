int n = 10;
int[] array = { 2, 3, 9, 5, 1, 12, 73, 23, 64, 62 };
int i = 0;
int max = 0;

while (i < n)
{
    if (array[i] > max)
    {
      max = array[i];
    }  
  
  i = i + 1;
}
Console.Write($"{max} ");
