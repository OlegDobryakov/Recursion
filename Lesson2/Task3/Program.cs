﻿int n = 10;
int[] array = { 2, 3, 9, 5, 1, 12, 73, 23, 64, 62 };
int i = 0;

while (i < n)
{
    if (array[i] % 2 == 0)
    {
      Console.Write($"{array[i]} ");
    }  
  
  i = i + 1;
}